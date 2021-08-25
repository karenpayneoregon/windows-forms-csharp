using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace LoadDataGridViewProgressBar.Classes
{
    public class Operations
    {

        private static string _connectionString = 
            "Data Source=.\\sqlexpress;Initial Catalog=NorthWind2020;Integrated Security=True";

        public static async Task<(Exception exception, DataTable dataTable)> LoadCustomerData()
        {

            var customersDataTable = new DataTable();

            using (var cn = new SqlConnection() { ConnectionString = _connectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    try
                    {
                        cmd.CommandText =
                            "SELECT  C.CustomerIdentifier, C.CompanyName, C.ContactId, CT.ContactTitle, C.City, CO.[Name] " + 
                            "FROM Customers AS C INNER JOIN ContactType AS CT ON C.ContactTypeIdentifier = CT.ContactTypeIdentifier " + 
                            "INNER JOIN Countries AS CO ON C.CountryIdentifier = CO.CountryIdentifier ";

        
                        await cn.OpenAsync();

                        customersDataTable.Load(await cmd.ExecuteReaderAsync());

                        customersDataTable.Columns["Name"].AllowDBNull = false;
                        customersDataTable.Columns["CustomerIdentifier"].ColumnMapping = MappingType.Hidden;
                        customersDataTable.Columns["ContactId"].ColumnMapping = MappingType.Hidden;


                    }
                    catch (Exception exception)
                    {
                        return (exception, customersDataTable);
                    }
                }
            }

            return (null, customersDataTable);

        }
    }
}
