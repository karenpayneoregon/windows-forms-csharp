using System;

namespace WindowsFormsApp3.Controls
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Format a TimeSpan with AM PM
        /// </summary>
        /// <param name="sender">TimeSpan to format</param>
        /// <param name="format">Optional format</param>
        /// <returns></returns>
        public static string Formatted(this TimeSpan sender, string format = "hh:mm tt") =>
            DateTime.Today.Add(sender).ToString(format);


    }
}