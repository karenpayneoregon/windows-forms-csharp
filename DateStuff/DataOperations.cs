using System.Collections.Generic;
using System.Data.SqlClient;

namespace SqlDemos
{
    public class DataOperations
    {
        private static string _connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=NorthWind2020;Integrated Security=True";

        public static List<Categories> GetCategoriesList()
        {
            List<Categories> list = new List<Categories>();
            using (var cn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = "SELECT CategoryID, CategoryName FROM dbo.Categories";
                    cn.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Categories() {CategoryId = reader.GetInt32(0), CategoryName = reader.GetString(1)});
                    }
                }
            }

            return list;
        }
    }
}