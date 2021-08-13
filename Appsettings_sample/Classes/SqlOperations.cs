using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Appsettings_sample.Classes.Helper;

namespace Appsettings_sample.Classes
{
    public class SqlOperations
    {
        /// <summary>
        /// Test connection for connection string in appsettings.json
        /// </summary>
        /// <returns></returns>
        public static (bool success, Exception exception) TestConnection()
        {
            try
            {
                using var cn = new SqlConnection() {ConnectionString = ConnectionString()};
                cn.Open();
                return (true, null);
            }
            catch (Exception exception)
            {
                return (false, exception);
            }
        }
    }
}
