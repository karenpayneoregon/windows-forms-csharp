using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp3.Controls
{
    public class Hours
    {
        public string[] Range(TimeIncrement pTimeIncrement = TimeIncrement.Hourly)
        {

            const string timeHhMmTtformat = "hh:mm tt";

            IEnumerable<DateTime> hours = Enumerable.Range(0, 24)
                .Select((index) => (DateTime.MinValue.AddHours(index)));

            var timeList = new List<string>();

            foreach (var dateTime in hours)
            {

                timeList.Add(dateTime.ToString(timeHhMmTtformat));

                if (pTimeIncrement == TimeIncrement.Quarterly)
                {
                    timeList.Add(dateTime.AddMinutes(15).ToString(timeHhMmTtformat));
                    timeList.Add(dateTime.AddMinutes(30).ToString(timeHhMmTtformat));
                    timeList.Add(dateTime.AddMinutes(45).ToString(timeHhMmTtformat));
                }
                else if (pTimeIncrement == TimeIncrement.HalfHour)
                {
                    timeList.Add(dateTime.AddMinutes(30).ToString(timeHhMmTtformat));
                }
            }

            return timeList.ToArray();

        }
    }
}