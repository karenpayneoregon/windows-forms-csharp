using System;
using System.Collections.Generic;
using System.Data;
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

        public static string ProductColumnNames()
        {
            using (var cn = new SqlConnection { ConnectionString = $"Data Source={DatabaseServer};Initial Catalog={DefaultCatalog};Integrated Security=True" })
            {
                using (var cmd = new SqlCommand { Connection = cn, CommandText = ColumnNamesQuery() })
                {
                    cn.Open();
                    return cmd.ExecuteScalar().ToString();
                }
            }
        }

        public static DataTable LoadProducts(string query)
        {
            using (var cn = new SqlConnection { ConnectionString = $"Data Source={DatabaseServer};Initial Catalog={DefaultCatalog};Integrated Security=True" })
            {
                using (var cmd = new SqlCommand { Connection = cn, CommandText = query })
                {
                    cn.Open();
                    DataTable table = new DataTable();
                    table.Load(cmd.ExecuteReader());
                    return table;
                }
            }
        }

        public static string ColumnNamesQuery()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("SELECT STRING_AGG(R.ColumnName, ',') ");
            builder.AppendLine("FROM");
            builder.AppendLine("(");
            builder.AppendLine("    SELECT TOP 100 COLUMN_NAME AS ColumnName FROM INFORMATION_SCHEMA.TABLES AS tbl");
            builder.AppendLine("         INNER JOIN INFORMATION_SCHEMA.COLUMNS AS col ON col.TABLE_NAME = tbl.TABLE_NAME");
            builder.AppendLine("         INNER JOIN sys.columns AS sc ON sc.object_id = OBJECT_ID(tbl.TABLE_SCHEMA + '.' + tbl.TABLE_NAME) AND sc.name = col.COLUMN_NAME");
            builder.AppendLine("         LEFT JOIN sys.extended_properties prop ON prop.major_id = sc.object_id AND prop.minor_id = sc.column_id AND prop.name = 'MS_Description'");
            builder.AppendLine("    WHERE tbl.TABLE_NAME = 'Products' ORDER BY COLUMN_NAME ) AS r;");





            return builder.ToString();
        }
    }
}
