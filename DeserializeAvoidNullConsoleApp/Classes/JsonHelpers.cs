using System.Text.Json;
using DeserializeAvoidNullConsoleApp.Converters;

namespace DeserializeAvoidNullConsoleApp.Classes
{

    public class JsonHelpers
    {
        /// <summary>
        /// Wrapper for setting up indent for write and converter for null string to empty string
        /// </summary>
        /// <returns></returns>
        public static JsonSerializerOptions JsonSerializerOptions() 
            => new()
            {
                WriteIndented = true,
                Converters = { new HandleNullToEmptyStringConverter() }
            };
    }
}
