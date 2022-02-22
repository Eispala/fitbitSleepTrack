using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBitSleeptrack
{
    public class Pagination
    {
        public string beforeDate { get; set; }
        public int limit { get; set; }
        public string next { get; set; }
        public int offset { get; set; }
        public string previous { get; set; }
        public string sort { get; set; }
    }

    public class sleepDetail
    {
        public DateTime dateTime { get; set; }
        public string level { get; set; }
        public int seconds { get; set; }

        public override string ToString()
        {
            return dateTime.ToString() + ";" + level + ";" + seconds + Environment.NewLine;
        }
    }

    public class ShortData
    {
        public DateTime dateTime { get; set; }
        public string level { get; set; }
        public int seconds { get; set; }
    }

    public class Deep
    {
        public int count { get; set; }
        public int minutes { get; set; }
        public int thirtyDayAvgMinutes { get; set; }
    }

    public class Light
    {
        public int count { get; set; }
        public int minutes { get; set; }
        public int thirtyDayAvgMinutes { get; set; }
    }

    public class Rem
    {
        public int count { get; set; }
        public int minutes { get; set; }
        public int thirtyDayAvgMinutes { get; set; }
    }

    public class Wake
    {
        public int count { get; set; }
        public int minutes { get; set; }
        public int thirtyDayAvgMinutes { get; set; }
    }

    public class Summary
    {
        public Deep deep { get; set; }
        public Light light { get; set; }
        public Rem rem { get; set; }
        public Wake wake { get; set; }
    }

    public class Levels
    {
        public IList<sleepDetail> data { get; set; }
        public IList<ShortData> shortData { get; set; }
        public Summary summary { get; set; }

    }

    public class Sleep
    {
        public string dateOfSleep { get; set; }
        public int duration { get; set; }
        public int efficiency { get; set; }
        public DateTime endTime { get; set; }
        public int infoCode { get; set; }
        public bool isMainSleep { get; set; }
        public Levels levels { get; set; }
        public object logId { get; set; }
        public int minutesAfterWakeup { get; set; }
        public int minutesAsleep { get; set; }
        public int minutesAwake { get; set; }
        public int minutesToFallAsleep { get; set; }
        public DateTime startTime { get; set; }
        public int timeInBed { get; set; }
        public string type { get; set; }

        public override string ToString()
        {
            return dateOfSleep + ";" + duration + ";" + efficiency + ";" + startTime.ToString() + ";" + endTime.ToString() + ";" + isMainSleep + ";" + minutesAfterWakeup
                + ";" + minutesAsleep + ";" + minutesAwake + ";" + minutesToFallAsleep + ";" + timeInBed + ";" + type + Environment.NewLine;
        }
    }

    public class SleepData
    {
        public Pagination pagination { get; set; }
        public IList<Sleep> sleep { get; set; }
    }

    public class SingleDateSleepData
    {
        public IList<Sleep> sleep { get; set; }
        public Summary summary { get; set; }
    }
}
