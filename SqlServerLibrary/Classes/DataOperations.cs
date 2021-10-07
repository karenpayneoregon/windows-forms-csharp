using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static SqlServerLibrary.Classes.SqlServerConnections;

namespace SqlServerLibrary.Classes
{
    public class DataOperations
    {
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
    }

    class Demo
    {
        public Demo()
        {
            var (exception, nameList) = DataOperations.ReadCategoryNames();
            if (exception is null)
            {
                // use list
            }
            else
            {
                // report issue
                // exception.Message
            }

        }
    }
}