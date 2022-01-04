using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ConfigurationMultipleEnvironments.Classes
{
    public class ConfigurationHelper
    {

        public static ConnectionsConfiguration CurrentEnvironment { get; private set; }
        public static string GetConnectionStringFromEnvironment()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            var map = configuration.GetSection("ConnectionsConfiguration").Get<ConfigurationMap>();
            ConnectionsConfiguration environment = map.ActiveEnvironment.ToEnum(ConnectionsConfiguration.Development);

            CurrentEnvironment = environment;

            return environment switch
            {
                ConnectionsConfiguration.Development => map.Development,
                ConnectionsConfiguration.Stage => map.Stage,
                ConnectionsConfiguration.Production => map.Production,
                _ => map.Development
            };

        }

        public static string GetConnectionStringFromJson()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json").AddEnvironmentVariables();
            var configuration = builder.Build();
            var map = configuration.GetSection("ConnectionsConfiguration").Get<ConfigurationMap>();

            /*
             * We can use ASPNETCORE_ENVIRONMENT or OED_ENVIRONMENT
             */
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT").ToEnum(ConnectionsConfiguration.Development);
            

            CurrentEnvironment = environment;

            return environment switch
            {
                ConnectionsConfiguration.Development => map.Development,
                ConnectionsConfiguration.Stage => map.Stage,
                ConnectionsConfiguration.Production => map.Production,
                _ => map.Development
            };

        }
    }
}
