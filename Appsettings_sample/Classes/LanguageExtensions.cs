using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appsettings_sample.Classes
{
    public static class LanguageExtensions
    {

        public static string ToYesNo(this int sender) => sender switch
        {
            0 => "No",
            1 => "Yes",
            _ => throw new InvalidOperationException($"Integer value {sender} is not valid")
        };

        public static string Determination0(this int sender)
        {
            var result = "";

            switch (sender)
            {
                case < 0:
                    result = "Less than or equal to 0";
                    break;
                case > 0 and <= 10:
                    result = "More than 0 but less than or equal to 10";
                    break;
                default:
                    result = "More than 10";
                    break;
            }

            return result;
        }
        /// <summary>
        /// use Switch expression to determine where a int value falls
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static string Determination1(this int sender) => sender switch
        {
            <= 0 => "Less than or equal to 0",
            > 0 and <= 10 => "More than 0 but less than or equal to 10",
            _ => "More than 10"
        };


        public static string DeterminationEx(this int sender) => sender switch
        {
            < 0 => "Less than or equal to 0",
            > 0 and <= 10 => "More than 0 but less than or equal to 10",
            _ => "More than 10"
        };

        public static string Determination2(this int sender)
        {
            var result = sender switch
            {
                < 0 => "Less than or equal to 0",
                > 0 and <= 10 => "More than 0 but less than or equal to 10",
                _ => "More than 10"
            };

            return result;
        }

        public static string Determination3(this int sender)
        {
            var result = sender switch
            {
                1 or 2 or 3 => "one two or three",
                4 => "four",
                _ => "More than four"
            };

            return result;
        }
        public static string DeterminationConventional(this int sender)
        {
            var result = "";

            if (sender < 0)
            {
                result = "Less than or equal to 0";
            }
            else if (sender > 0 && sender <= 10)
            {
                result = "More than 0 but less than or equal to 10";
            }
            else
            {
                result = "More than 10";
            }

            return result;
        }

        public static string FormatElapsed(this TimeSpan span) => span.Days switch
        {
            > 0 => $"{span.Days} days, {span.Hours} hours, {span.Minutes} minutes, {span.Seconds} seconds",
            _ => span.Hours switch
            {
                > 0 => $"{span.Hours} hours, {span.Minutes} minutes, {span.Seconds} seconds",
                _ => span.Minutes switch
                {
                    > 0 => $"{span.Minutes} minutes, {span.Seconds} seconds",
                    _ => span.Seconds switch
                    {
                        > 0 => $"{span.Seconds} seconds",
                        _ => ""
                    }
                }
            }
        };

        public static IEnumerable<DateTime> Range(this DateTime startDate, DateTime endDate) 
            => Enumerable.Range(0, (endDate - startDate).Days + 1).Select(d => startDate.AddDays(d));


    }

}
