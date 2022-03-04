using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace SqlServerInsertRecord.Classes
{
    public class DataOperations
    {
        private static string connection = "Data Source=.\\sqlexpress;Initial Catalog=NorthWind2020;Integrated Security=True";

        public static (DataTable table, Exception exception) SelectRow(string contactId)
        {
            DataTable table = new DataTable();

            try
            {
                using (var cn = new SqlConnection { ConnectionString = connection })
                {
                    using (var cmd = new SqlCommand { Connection = cn })
                    {
                        cmd.CommandText = "SELECT FirstName, LastName FROM dbo.Contacts WHERE ContactId = @contactId;";
                        cmd.Parameters.Add("@contactId", SqlDbType.NVarChar).Value = contactId;
                        cn.Open();
                        table.Load(cmd.ExecuteReader());
                        return (table, null);
                    }
                }
            }
            catch (Exception exception)
            {
                return (null, exception);
            }


        }
        public static (DataTable table, Exception exception) SelectTable()
        {
            DataTable table = new DataTable();

            try
            {
                using (var cn = new SqlConnection { ConnectionString = connection })
                {
                    using (var cmd = new SqlCommand { Connection = cn })
                    {
                        cmd.CommandText = "SELECT FirstName, LastName FROM dbo.Contacts;";

                        cn.Open();
                        table.Load(cmd.ExecuteReader());
                        return (table, null);
                    }
                }
            }
            catch (Exception exception)
            {
                return (null, exception);
            }


        }


        public static Contact SelectContact(string contactId)
        {

            Contact contact = new Contact() {ContactId = contactId};
            
            using (var cn = new SqlConnection { ConnectionString = connection })
            {
                using (var cmd = new SqlCommand { Connection = cn  })
                {
                    cmd.CommandText = "SELECT FirstName, LastName FROM dbo.Contacts WHERE ContactId = @contactId;";
                    cmd.Parameters.Add("@contactId", SqlDbType.NVarChar).Value = contactId;
                    cn.Open();

                    var reader = cmd.ExecuteReader();
                    
                    if (reader.HasRows)
                    {
                        reader.Read();
                        contact.FirstName = reader.GetString(0);
                        contact.LastName = reader.GetString(1);
                    }

                }
            }

            return contact;
        }
    }

    public class Contact
    {
        // seems this would be an int
        public string ContactId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString() => $"{FirstName} {LastName}";

    }
}
