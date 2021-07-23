using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadsheetLightDataGridViewExport.Classes
{
    public class DataOperations
    {
        private static string ConnectionString =
            "Data Source=.\\SQLEXPRESS;Initial Catalog=NorthWind2020;Integrated Security=True";

        public static DataTable Read()
        {
            DataTable table = new DataTable();

            var selectStatement = 
                "SELECT TOP 5 O.OrderID, O.CustomerIdentifier, C.CompanyName, O.OrderDate, O.RequiredDate, O.ShippedDate " + 
                "FROM Orders AS O INNER JOIN Customers AS C ON O.CustomerIdentifier = C.CustomerIdentifier";

            using (var cn = new SqlConnection {ConnectionString = ConnectionString})
            {
                using (var cmd = new SqlCommand {Connection = cn, CommandText = selectStatement })
                {
                    cn.Open();
                    table.Load(cmd.ExecuteReader());
                }
            }

            return table;
        }
    }
}
