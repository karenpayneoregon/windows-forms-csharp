
using System;

namespace TimeLibrary.Classes
{
    public class Helpers
    {
        /// <summary>
        /// Format elapsed time to a string
        /// </summary>
        /// <param name="years"></param>
        /// <param name="months"></param>
        /// <param name="days"></param>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        /// <remarks>
        /// Not fully tested
        /// </remarks>
        public static string Elapsed(int years, int months, int days, int hours, int minutes, int seconds, string result)
        {
            result = years switch
            {
                0 when months > 0 => $"{months} months {days} days {hours} hours {minutes} minutes {seconds} seconds",
                0 when months == 0 => $"{days} days {hours} hours {minutes} minutes {seconds} seconds",
                0 when months > 0 => $"{months} months {days} days {hours} hours {minutes} minutes {seconds} seconds",
                0 when months == 0 && days == 0 => $"{hours} hours {minutes} minutes {seconds} seconds",
                _ => result
            };

            return result;
        }
        /// <summary>
        /// Get elapsed time in years, months, days, hours, seconds
        /// </summary>
        /// <param name="fromDate">Date in past</param>
        /// <param name="toDate">Date pass fromDate</param>
        /// <param name="years"></param>
        /// <param name="months"></param>
        /// <param name="days"></param>
        /// <param name="hours"></param>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        /// <param name="milliseconds"></param>
        public static void GetElapsedTime(DateTime fromDate, DateTime toDate, out int years, out int months, out int days, out int hours, out int minutes, out int seconds, out int milliseconds)
        {
            // If from_date > to_date, switch them around.
            if (fromDate > toDate)
            {
                GetElapsedTime(
                    toDate, 
                    fromDate, 
                    out years, 
                    out months, 
                    out days, 
                    out hours, 
                    out minutes, 
                    out seconds, 
                    out milliseconds);
                
                years = -years;
                months = -months;
                days = -days;
                hours = -hours;
                minutes = -minutes;
                seconds = -seconds;
                milliseconds = -milliseconds;
            }
            else
            {
                // Handle the years.
                years = toDate.Year - fromDate.Year;

                // See if we went too far.
                DateTime testDate = fromDate.AddMonths(12 * years);
                if (testDate > toDate)
                {
                    years--;
                    testDate = fromDate.AddMonths(12 * years);
                }

                // Add months until we go too far.
                months = 0;
                while (testDate <= toDate)
                {
                    months++;
                    testDate = fromDate.AddMonths(12 * years + months);
                }

                months--;

                // Subtract to see how many more days,
                // hours, minutes, etc. we need.
                fromDate = fromDate.AddMonths(12 * years + months);
                TimeSpan remainder = toDate - fromDate;
                days = remainder.Days;
                hours = remainder.Hours;
                minutes = remainder.Minutes;
                seconds = remainder.Seconds;
                milliseconds = remainder.Milliseconds;
                
            }
        }
    }
}
