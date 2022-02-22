using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FitBitSleeptrack
{
    internal class CustomContext
    {

        public HttpListener Listener;
        public DataSource DataSource;
        public string DateString;
        public int BeforeAfterIndex;
        public int BeforeAfterLimit;

        public CustomContext(HttpListener listener, DataSource dataSource, string dateString, int beforeAfterIndex, int beforeAfterLimit)
        {
            Listener = listener;
            DataSource = dataSource;
            this.DateString = dateString;
            this.BeforeAfterIndex = beforeAfterIndex;
            this.BeforeAfterLimit = beforeAfterLimit;
        }
    }
}
