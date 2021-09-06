using System;
using System.IO;
using System.Text.Json;

namespace CustomersDemo
{
    public static class SystemJson
    {
        public static (bool result, Exception exception) JsonToFile<T>(this T sender, string fileName, bool format = true)
        {

            try
            {
                /*
                 * explore other options besides WriteIndented
                 */
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                File.WriteAllText(fileName, JsonSerializer.Serialize(sender, format ? options : null));

                return (true, null);

            }
            catch (Exception exception)
            {
                return (false, exception);
            }

        }
    }
}
