using System;
using System.Data;
using System.Data.SqlClient;
using SqlServerInsertRecord.Models;

namespace SqlServerInsertRecord.Classes
{
    public class Operations
    {
        private static string _connectionString =
            "Data Source=.\\sqlexpress;Initial Catalog=ForumExample;Integrated Security=True";

        public static (bool success, Exception exception) Insert(Employee employee)
        {
            using (var cn = new SqlConnection { ConnectionString = _connectionString })
            {
                using (var cmd = new SqlCommand { Connection = cn })
                {
                    
                    cmd.CommandText = "INSERT INTO dbo.employee (FirstName, LastName, HiredDate) " +
                                      "VALUES (@FirstName, @LastName, @HiredDate);" +
                                      "SELECT CAST(scope_identity() AS int);";

                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = employee.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = employee.LastName;
                    
                    if (employee.HiredDate.HasValue)
                    {
                        cmd.Parameters.Add("@HiredDate", SqlDbType.DateTime).Value = employee.HiredDate.Value;
                    }
                    else
                    {
                        cmd.Parameters.Add("@HiredDate", SqlDbType.DateTime).Value = DBNull.Value;
                    }

                    try
                    {
                        cn.Open();

                        employee.Id = Convert.ToInt32(cmd.ExecuteScalar());

                        return (true, null);

                    }
                    catch (Exception ex)
                    {
                        return (false, ex);
                    }
                }
            }
        }
    }
}
