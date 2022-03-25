using System;

namespace CoreExtensions.LanguageExtensions
{

    public static class StringExtensions
    {
        public static DateTime ToDateTime(this string sender)
        {
            return string.IsNullOrWhiteSpace(sender) ? throw new Exception("Cannot convert an empty string to DateTime") :
                DateTime.TryParse(sender, out var value) ? value :
                throw new Exception($"Cannot convert [{sender}] to DateTime");
        }

        public static (DateTime dateTime, bool valid) ToDateTimeSafe(this string sender)
        {
            return string.IsNullOrWhiteSpace(sender) ? 
                (DateTime.Now, false) : 
                DateTime.TryParse(sender, out var value) ? 
                    (value, true) : 
                    (DateTime.Now, false);
        }
    }
}
