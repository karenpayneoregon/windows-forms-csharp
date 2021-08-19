using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace SqlServerAsyncReadCore.Classes
{
    public class DataOperations
    {
        private static string _connectionString =
            "Data Source=.\\sqlexpress;Initial Catalog=NorthWind2020;Integrated Security=True";


        public static async Task<DataTable> ReadProductsTask(CancellationToken ct)
        {

            return await Task.Run(async () =>
            {
                var productTable = new DataTable();

                await using var cn = new SqlConnection(_connectionString);
                await using var cmd = new SqlCommand {Connection = cn, CommandText = SelectStatement()};
                try
                {
                    await cn.OpenAsync(ct);
                }
                catch (TaskCanceledException tce)
                {
                    return null;
                }
                catch (Exception ex)
                {
                    return null;
                }

                productTable.Load(await cmd.ExecuteReaderAsync(ct));

                return productTable;

            });

        }




        #region So there is no guessing when working with data in the form
        /// <summary>
        /// Product table primary key <see cref="ReadProductsTask"/>
        /// </summary>
        public static readonly string PrimaryKey = "ProductID";
        /// <summary>
        /// What to display in CheckedListBox
        /// </summary>
        public static readonly string DisplayColumn = "ProductName";
        #endregion

        /// <summary>
        /// Responsible for reading products in 
        /// </summary>
        /// <returns></returns>
        private static string SelectStatement()
        {
            return $"SELECT P.{PrimaryKey}, P.{DisplayColumn}, P.SupplierID, S.CompanyName, P.CategoryID, " +
                   "C.CategoryName, P.QuantityPerUnit, P.UnitPrice, P.UnitsInStock, P.UnitsOnOrder, " +
                   "P.ReorderLevel, P.Discontinued, P.DiscontinuedDate " +
                   "FROM  Products AS P INNER JOIN Categories AS C ON P.CategoryID = C.CategoryID " +
                   "INNER JOIN Suppliers AS S ON P.SupplierID = S.SupplierID";
        }

    }

}
