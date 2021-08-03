using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SimpleSingleton.Classes
{
    public class SqlOperations
    {
        public static (bool success, Exception exception) GetUserInformation(string userName, string userPassword)
        {

            var info = new UserInfo();

            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["MYCUSTOMAPPDatabaseString"].ConnectionString;
                
                using (var cn = new SqlConnection { ConnectionString = connectionString })
                {
                    using (var cmd = new SqlCommand("dbo.LoginUser", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = userName;
                        cmd.Parameters.Add("@UserPassword", SqlDbType.NVarChar).Value = userName;

                        cn.Open();

                        var reader = cmd.ExecuteReader();
                        
                        if (reader.HasRows)
                        {
                            reader.Read();

                            // adjust according to column order in select statement in the stored procedure
                            info.userType = reader.GetString(0);
                            info.userName = reader.GetString(1);
                            info.userUserName = reader.GetString(2);
                            info.userType = reader.GetString(3);
                            info.userPhone = reader.GetString(4);
                            info.userIdCard = reader.GetString(5);
                            
                            ApplicationSettings.Instance.Info = info;

                            return (true, null);
                            
                        }
                        else
                        {
                            return (false, null);
                        }
                    }

                }
            }
            catch (Exception exception)
            {
                return (false, exception);
            }
        }
    }
}
