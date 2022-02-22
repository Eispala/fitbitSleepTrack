using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FitBitSleeptrack
{
    enum DataSource
    {
        singleDay,
        multiDay,
    }
    enum RequestBeforeAfter
    {
        beforeDate = 0,
        afterDate = 1
    }

    internal class Controller
    {
        HttpClient httpClient = new HttpClient();
        public string fileName = "";
        public ToolStripStatusLabel statusLabel;
        Process webBrowserProcess = new Process();

        public RichTextBox logbox;

        public void ExecuteRequest(DataSource dataSource, string dateString, int beforeAfterIndex, int beforeAfterLimit)
        {
            statusLabel.Text = "Bitte im neuen Fenster mit FitBit Account anmelden";
            //listenForRedirect(dataSource, dateString, beforeAfterIndex, beforeAfterLimit);
            startAuthentication(dataSource, dateString, beforeAfterIndex, beforeAfterLimit);

        }

        private string requestSleepData(BearerToken bearerToken, string requestURL, DataSource dataSource)
        {

            HttpRequestMessage httpRequestGetSleepData = new HttpRequestMessage(HttpMethod.Get, requestURL);
            httpRequestGetSleepData.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken.access_token);
            var SleepDataResponse = httpClient.Send(httpRequestGetSleepData);

            var sleepDataJson = SleepDataResponse.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            StringBuilder stringBuilder = new StringBuilder();

            if (dataSource == DataSource.singleDay)
            {
                SingleDateSleepData? sleepDataObject = JsonSerializer.Deserialize<SingleDateSleepData>(sleepDataJson);
                if(sleepDataObject == null)
                {
                    return "";
                }

                foreach (Sleep sleepRecord in sleepDataObject.sleep)
                {
                    stringBuilder.Append(sleepRecord.ToString());
                    foreach (sleepDetail sleepData in sleepRecord.levels.data)
                    {
                        stringBuilder.Append(sleepData.ToString());
                    }

                    stringBuilder.Append(Environment.NewLine);
                }
            }

            if (dataSource == DataSource.multiDay)
            {
                SleepData? multiDaySleepData = JsonSerializer.Deserialize<SleepData>(sleepDataJson);

                if (multiDaySleepData == null)
                {
                    return "";
                }

                foreach (Sleep sleepRecord in multiDaySleepData.sleep)
                {
                    stringBuilder.Append(sleepRecord.ToString());
                    foreach (sleepDetail sleepData in sleepRecord.levels.data)
                    {
                        stringBuilder.Append(sleepData.ToString());
                    }

                    stringBuilder.Append(Environment.NewLine);
                }

            }

            return stringBuilder.ToString();
        }

        private Tuple<BearerToken, string> requestBearerToken(DataSource dataSource, string dateString, int beforeAfterIndex, int beforeAfterLimit, string authenticationToken)
        {
            string requestURL = "";

            switch (dataSource)
            {
                case DataSource.singleDay:
                    requestURL = $"https://api.fitbit.com/1.2/user/-/sleep/date/{dateString}.json";
                    break;

                case DataSource.multiDay:
                    requestURL = $"https://api.fitbit.com/1.2/user/-/sleep/list.json?{(RequestBeforeAfter)beforeAfterIndex}={dateString}&sort=desc&offset=0&limit={beforeAfterLimit}";
                    break;
            }

            HttpRequestMessage httpRequestBearerToken = new HttpRequestMessage(HttpMethod.Post, "https://api.fitbit.com/oauth2/token");
            httpRequestBearerToken.Headers.Authorization = new AuthenticationHeaderValue("Basic", "MjM4MjdXOjYxOWE1MDRiYzk0NDkwMTZhNjMwMjhkNDc3ODZlNDYy");
            httpRequestBearerToken.Content = new StringContent($"clientId=23827W&grant_type=authorization_code&redirect_uri=https%3A%2F%2Flocalhost%3A55469%2Ffitbit%2Fredirect&code={authenticationToken}");
            httpRequestBearerToken.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            var bearerTokenResponse = httpClient.Send(httpRequestBearerToken);
            var bearerTokenResult = bearerTokenResponse.Content.ReadAsStringAsync();

            var bearerTokenJson = bearerTokenResult.GetAwaiter().GetResult();

            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.UnknownTypeHandling = JsonUnknownTypeHandling.JsonElement;

            return new Tuple<BearerToken, string>(JsonSerializer.Deserialize<BearerToken>(bearerTokenJson), requestURL);

        }
        private void listenForRedirect(DataSource dataSource, string dateString, int beforeAfterIndex, int beforeAfterLimit)
        {
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("https://localhost:55469/fitbit/");
            listener.Prefixes.Add("https://localhost:55469/fitbit/redirect/");
            
            listener.Start();

            CustomContext context = new(listener, dataSource, dateString, beforeAfterIndex, beforeAfterLimit);

            listener.BeginGetContext(new AsyncCallback(ListenerCallback), context);
        }

        private void startAuthentication(DataSource dataSource, string dateString, int beforeAfterIndex, int beforeAfterLimit)
        {
            
            webBrowserProcess.StartInfo.FileName = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
            webBrowserProcess.StartInfo.Arguments = @"-inprivate https://www.fitbit.com/oauth2/authorize?response_type=code&client_id=23827W&redirect_uri=https%3A%2F%2Flocalhost%3A55469%2Ffitbit%2Fredirect&scope=sleep&expires_in=604800";
            webBrowserProcess.Start();

            frmPopUp frmPopUp = new frmPopUp(); 
            
            if(frmPopUp.ShowDialog() == DialogResult.OK)
            {
                statusLabel.Text = "Daten werden abgerufen";
                string authenticationCode = parseAuthenticationCode(frmPopUp.pastedURL);

                webBrowserProcess.Kill(false);

                var BearerTokenAndRequestURL = requestBearerToken(dataSource, dateString, beforeAfterIndex, beforeAfterLimit, authenticationCode);
                var csvData = requestSleepData(BearerTokenAndRequestURL.Item1, BearerTokenAndRequestURL.Item2, dataSource);

                File.WriteAllText(fileName + ".csv", csvData);

                statusLabel.Text = $"Datei {fileName}.csv gespeichert - Bereit";
            }
        }

        private string parseAuthenticationCode(string redirectedURL)
        {
            var accessToken = redirectedURL.Replace("https://localhost:55469/fitbit/redirect?code=", "");
            accessToken = accessToken.Replace("#_=_", "");
            return accessToken;
        }

        private void ListenerCallback(IAsyncResult result)
        {
            statusLabel.Text = "Daten werden abgerufen";

            CustomContext context = (CustomContext)result.AsyncState;

            var httpResult = context.Listener.EndGetContext(result);

            context.Listener.Stop();

            string authenticationCode = parseAuthenticationCode(httpResult.Request.RawUrl);

            webBrowserProcess.Kill(false);

            var BearerTokenAndRequestURL = requestBearerToken(context.DataSource, context.DateString, context.BeforeAfterIndex, context.BeforeAfterLimit, authenticationCode);
            var csvData = requestSleepData(BearerTokenAndRequestURL.Item1, BearerTokenAndRequestURL.Item2, context.DataSource);

            File.WriteAllText(fileName + ".csv", csvData);

            statusLabel.Text = $"Datei {fileName}.csv gespeichert - Bereit";
            
        }
    }
}
