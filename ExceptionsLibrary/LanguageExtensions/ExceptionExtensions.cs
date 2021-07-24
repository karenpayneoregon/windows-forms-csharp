using System;

namespace ExceptionsLibrary.LanguageExtensions
{
    /// <summary>
    /// Useful for quick-and-dirty when writing code and issues are encountered.
    /// Not meant for production use.
    /// </summary>
    public static class ExceptionExtensions
    {
        public static string GetExceptionMessages(this Exception sender, string result = "")
        {
            try
            {
                if (sender == null) return string.Empty;

                if (string.IsNullOrWhiteSpace(result)) result = sender.Message;

                if (sender.InnerException != null)
                {
                    result += $": InnerException: {GetExceptionMessages(sender.InnerException)}";
                }

                return result;
                
            }
            catch (Exception exception)
            {
                return $"Failure in ExceptionExtensions.{nameof(GetExceptionMessages)}: [{exception.Message}]";
            }
        }
        public static string GetExceptionMessagesLineFeeds(this Exception sender, string result = "")
        {
            try
            {
                if (sender == null) return string.Empty;

                if (string.IsNullOrWhiteSpace(result)) result = sender.Message;

                if (sender.InnerException != null)
                {
                    result += $"\n\tInnerException: {GetExceptionMessagesLineFeeds(sender.InnerException)}";
                }

                return result;
            }
            catch (Exception exception)
            {
                return $"Failure in ExceptionExtensions.{nameof(GetExceptionMessagesLineFeeds)}: [{exception.Message}]";
            }
        }
    }
}
