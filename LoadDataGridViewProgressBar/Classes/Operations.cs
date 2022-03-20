using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace LoadDataGridViewProgressBar.Classes
{
    public class Operations
    {

        private static string _connectionString = 
            "Data Source=.\\sqlexpress;Initial Catalog=NorthWind2020;Integrated Security=True";

        public static (bool success, Exception exception) Insert(List<DataRow> rows)
        {
            using (var cn = new SqlConnection() { ConnectionString = _connectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = "INSERT INTO Customers VALUES (@CompanyName, @ContactId)";
                    cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@ContactId", SqlDbType.Int);

                    try
                    {
                        cn.Open();

                        foreach (var row in rows)
                        {
                            cmd.Parameters["@CompanyName"].Value = row.Field<string>("CompanyName");
                            cmd.Parameters["@ContactId"].Value = row.Field<string>("ContactId");
                            cmd.ExecuteNonQuery();
                        }

                        return (true, null);
                    }
                    catch (Exception localException)
                    {
                        return (false, localException);
                    }
                }
            }
        }
        public static async Task<(Exception exception, DataTable dataTable)> LoadCustomerDataTable()
        {

            var customersDataTable = new DataTable();

            using (var cn = new SqlConnection() { ConnectionString = _connectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    try
                    {
                        cmd.CommandText =
                            "SELECT  C.CustomerIdentifier, C.CompanyName, C.ContactId, CT.ContactTitle, C.City, CO.[Name] AS CountryName " + 
                            "FROM Customers AS C INNER JOIN ContactType AS CT ON C.ContactTypeIdentifier = CT.ContactTypeIdentifier " + 
                            "INNER JOIN Countries AS CO ON C.CountryIdentifier = CO.CountryIdentifier ";

        
                        await cn.OpenAsync();

                        customersDataTable.Load(await cmd.ExecuteReaderAsync());

                        customersDataTable.Columns["CountryName"].AllowDBNull = false;
                        customersDataTable.Columns["CustomerIdentifier"].ColumnMapping = MappingType.Hidden;
                        customersDataTable.Columns["ContactId"].ColumnMapping = MappingType.Hidden;


                    }
                    catch (Exception exception)
                    {
                        return (exception, customersDataTable);
                    }
                }
            }

            foreach (DataColumn column in customersDataTable.Columns)
            {
                Console.WriteLine($"{column.ColumnName}\t{column.DataType}");
            }
            return (null, customersDataTable);

        }
        public static async Task<(Exception exception,  List<Customer> customers)> LoadCustomerList()
        {


            var list = new List<Customer>();

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

                        var reader = await cmd.ExecuteReaderAsync();

                        while (reader.Read())
                        {
                            list.Add(new Customer()
                            {
                                CustomerIdentifier = reader.GetInt32(0), 
                                CompanyName = reader.GetString(1), 
                                ContactId = reader.GetInt32(2), 
                                ContactTitle = reader.GetString(3), 
                                Country = reader.GetString(4)
                            });
                        }

                    }
                    catch (Exception exception)
                    {
                        return (exception, list);
                    }
                }
            }

            return (null, list);

        }

        public static bool RemoveCustomer(int customerCustomerIdentifier)
        {
            return true;
        }
    }
}
