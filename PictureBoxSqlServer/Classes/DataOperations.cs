using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PictureBoxSqlServer.Classes
{
    public class DataOperations
    {
        private static string ConnectionString = 
            "Data Source=.\\SQLEXPRESS;Initial Catalog=NorthWind2020;Integrated Security=True";

        /// <summary>
        /// Read all <see cref="Categories"/> into a list
        /// </summary>
        /// <returns>List&lt;Categories&gt;</returns>
        /// <remarks>
        /// No exception handling done, feel free to add if you want too.
        /// </remarks>
        public static List<Categories> ReadCategoriesList()
        {
            List<Categories> categoriesList = new List<Categories>();
            
            var selectStatement = 
                "SELECT CategoryID, CategoryName, Picture " + 
                "FROM Categories AS C " + 
                "WHERE Picture IS NOT NULL;";

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() {Connection = cn, CommandText = selectStatement})
                {
                    cn.Open();
                    
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        var category = new Categories
                        {
                            CategoryID = reader.GetInt32(0), 
                            CategoryName = reader.GetString(1), 
                            Picture = (byte[]) reader["Picture"]
                        };
                        
                        categoriesList.Add(category);

                    }
                }
            }

            return categoriesList;

        }
        /// <summary>
        /// Get a <see cref="Categories"/> record by primary key
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns><see cref="Categories"/></returns>
        /// <remarks>
        /// No exception handling done, feel free to add if you want too.
        /// </remarks>
        public static Categories ReadCategories(int identifier)
        {
            Categories categories = new Categories();
            
            var selectStatement = 
                "SELECT CategoryName, Picture " + 
                "FROM Categories AS C " + 
                "WHERE C.CategoryID = @CategoryID;";

            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn, CommandText = selectStatement })
                {
                    cmd.Parameters.Add("@CategoryID", SqlDbType.Int).Value = identifier;
                    
                    cn.Open();
                    
                    var reader = cmd.ExecuteReader();

                    reader.Read();
           
                    categories.CategoryID = identifier;
                    categories.CategoryName = reader.GetString(0);
                    categories.Picture = (byte[]) reader["Picture"];

                }
            }

            return categories;

        }
    }
}