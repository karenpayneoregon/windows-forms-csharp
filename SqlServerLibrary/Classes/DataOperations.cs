using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using static SqlServerLibrary.Classes.SqlServerConnections;

namespace SqlServerLibrary.Classes
{
    public class DataOperations
    {
        public static void Demo()
        {
            using var cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ForumExample;Integrated Security=True");
            var sql = "SELECT LEN(PetName) +2 AS length FROM Pet WHERE LEN(PetName) = " + 
                      "(SELECT MAX(LEN(PetName)) FROM Pet)";

            using var cmd = new SqlCommand(sql, cn);

            cn.Open();

            var nameLength = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.CommandText = "SELECT MakeId, PetName, Color FROM dbo.Pet;";

            SqlDataReader reader = cmd.ExecuteReader();
            
            Debug.WriteLine("++++++++ Fun with Data Readers AutoLot++++++++++++");
            while (reader.Read())
            {
                Debug.WriteLine($"-> Make : {reader.GetInt32(0),-4}PetName : {reader.GetString(1).PadRight(nameLength)}Color : {reader.GetString(2)}");
            }

        }
        public static (Exception exception, List<string> nameList) ReadCategoryNames()
        {
            List<string> names = new ();

            using var cn = Instance.Connection(Instance.ConnectionString);

            const string selectStatement = "SELECT CategoryName FROM dbo.Categories";

            using var cmd = new SqlCommand() { Connection = cn, CommandText = selectStatement };

            try
            {
                cn.Open();

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    names.Add(reader.GetString(0));
                }

                return (null, names);

            }
            catch (Exception e)
            {
                return (e, null);
            }

        }

        public static (bool success, Exception exception) DemoInsert(string companyName, ref int newIdentifier)
        {
            using var cn = new SqlConnection { ConnectionString = "TODO" };
            using var cmd = new SqlCommand { Connection = cn };

            cmd.CommandText = "INSERT INTO [Customer] (CompanyName) " +
                              "VALUES (@CompanyName); " +
                              "SELECT CAST(scope_identity() AS int);";

            cmd.Parameters.Add("", SqlDbType.NVarChar).Value = companyName;

            try
            {
                cn.Open();

                newIdentifier = (int)cmd.ExecuteScalar();
                return (true, null);
            }
            catch (Exception ex)
            {
                return (false, ex);
            }
        }
    }

    
}