using System.IO;
using Microsoft.Extensions.Configuration;

namespace Appsettings_sample.Classes
{
    public class Helper
    {
        public static string ConnectionString()
        {
            InitConfiguration();
            return InitOptions<DatabaseSettings>("database").ConnectionString;
        }
        private static IConfigurationRoot InitConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            return builder.Build();
        }
        public static T InitOptions<T>(string section) where T : new()
        {
            IConfigurationRoot config = InitConfiguration();
            return config.GetSection(section).Get<T>();
        }
    }
}
