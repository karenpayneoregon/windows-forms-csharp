using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SqlDemos.OtherForms;

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

        public static DataTable GetCategories()
        {

            DataTable table = new DataTable();
            using (var cn = new SqlConnection(_connectionString))
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = "SELECT CategoryID, CategoryName, Picture FROM dbo.Categories";
                    cn.Open();
                    table.Load(cmd.ExecuteReader());
                    table.Columns["CategoryID"].ColumnMapping = MappingType.Hidden;
                }
            }

            return table;
        }
    }
}