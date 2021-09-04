using System;
using System.Data;
using System.Data.SqlClient;

namespace StudentRegistration.Classes
{
    public class SqlOperations
    {
        private static string _connectionString =
            "Data Source=.\\sqlexpress;Initial Catalog=ForumExample;Integrated Security=True";
        public static (bool success, Exception exception) Add(Person person)
        {
            using (var cn = new SqlConnection { ConnectionString = _connectionString })
            {
                using (var cmd = new SqlCommand { Connection = cn })
                {

  
                    cmd.CommandText = "INSERT INTO dbo.People (FirstName, LastName,Gender,BirthDay,PhoneNumber) " +
                                      "VALUES (@FirstName, @LastName, @Gender, @BirthDay,@PhoneNumber);" +
                                      "SELECT CAST(scope_identity() AS int);";

                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = person.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = person.LastName;
                    cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = person.Gender;
                    cmd.Parameters.Add("@BirthDay", SqlDbType.DateTime).Value = person.BirthDay.Value;
                    cmd.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = person.PhoneNumber;

                    try
                    {
                        cn.Open();

                        person.Id = Convert.ToInt32(cmd.ExecuteScalar());

                        return (true, null);

                    }
                    catch (Exception exception)
                    {
                        return (false, exception);
                    }
                }
            }
        }
    }
}