using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace SqlDemos
{
    public class Helpers
    {
        public static bool ConnectionExists(string name)
        {
            return ConfigurationManager
                .ConnectionStrings
                .OfType<ConnectionStringSettings>()
                .FirstOrDefault(x => x.Name == name) != null;

        }

        public static bool ConfigurationFileExists()
        {
            return File.Exists($"{AppDomain.CurrentDomain.FriendlyName}.config");
        }

        public static bool CanConnect(string connectionString)
        {
            using (var cn = new SqlConnection(connectionString))
            {
                try
                {
                    cn.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
}