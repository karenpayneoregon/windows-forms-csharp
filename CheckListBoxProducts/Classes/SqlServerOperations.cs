using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckListBoxProducts.Classes
{
    public class SqlServerOperations
    {
        public static string DefaultCatalog = "NorthWind2020";
        public static string DatabaseServer = ".\\SQLEXPRESS";

        public static List<Product> ProductsByCategoryIdentifier(int pCategoryIdentifier)
        {
            List<Product> productList = new List<Product>();

            var selectStatement = 
                @"SELECT 
                    ProductID, 
                    ProductName, 
                    SupplierID, 
                    QuantityPerUnit, 
                    UnitPrice, 
                    UnitsInStock, 
                    UnitsOnOrder, 
                    ReorderLevel, 
                    Discontinued 
                FROM dbo.Products 
                WHERE CategoryID = @Identifier";

            using (var cn = new SqlConnection { ConnectionString = $"Data Source={DatabaseServer};Initial Catalog={DefaultCatalog};Integrated Security=True" })
            {
                using (var cmd = new SqlCommand { Connection = cn, CommandText = selectStatement })
                {

                    cmd.Parameters.AddWithValue("@Identifier", pCategoryIdentifier);
                    
                    cn.Open();

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        productList.Add(new Product()
                        {
                            ProductID = reader.GetInt32(0),
                            ProductName = reader.GetString(1),
                            Discontinued = reader.GetBoolean(8)
                        });
                    }
                }

            }

            return productList;
        }
    }
}
