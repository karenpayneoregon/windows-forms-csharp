using System.Configuration;
using System.Data.OleDb;
using System.IO;
using static System.Configuration.ConfigurationManager;

namespace AccessMultiConnections.Classes
{
    public class ConnectionHelper
    {
        /// <summary>
        /// Location of all databases
        /// </summary>
        public static string BasePath = 
            "C:\\OED\\Dotnetland\\Misc\\Databases";

        /// <summary>
        /// Change database connection by index in connection string section
        /// </summary>
        /// <param name="source">Path and database name</param>
        /// <param name="index">ordinal index of connection string</param>
        /// <remarks>
        /// Can change index parameter to a string name representing the connection
        /// string if desire.
        /// </remarks>
        public static void ChangeConnection(string source, int index = 2)
        {
            var config = OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config
                .GetSection("connectionStrings");

            // in this case the index to the connection string is 2
            var current = connectionStringsSection.ConnectionStrings[index]
                .ConnectionString;

            var builder = new OleDbConnectionStringBuilder(current)
            {
                DataSource = source
            };

            connectionStringsSection.ConnectionStrings[index].ConnectionString = 
                builder.ConnectionString;

            config.Save();

            RefreshSection("connectionStrings");
            Properties.Settings.Default.Reload();

        }

        /// <summary>
        /// Provides the current database name without a path in appsettings.config
        /// </summary>
        /// <param name="index">ordinal index of connection string</param>
        /// <returns>File name for current connection</returns>
        public static string CurrentConnectionString(int index = 2)
        {
            var config = OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config
                .GetSection("connectionStrings");

            var builder = 
                new OleDbConnectionStringBuilder(
                    connectionStringsSection.ConnectionStrings[index]
                        .ConnectionString);

            return Path.GetFileName(builder.DataSource);
        }
    }
}
