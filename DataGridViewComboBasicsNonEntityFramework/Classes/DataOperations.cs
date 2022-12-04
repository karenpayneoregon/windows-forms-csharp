using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridViewCombo1.Classes
{
    class DataOperations
    {
        private string ConnectionString = 
            "Data Source=.\\sqlexpress;Initial " + 
            "Catalog=DataGridViewCodeSample;Integrated Security=True";


        public (DataTable customerTable, DataTable colorTable) LoadData()
        {
            DataTable dtCustomer = new DataTable();
            DataTable dtColor = new DataTable();

            using (var cn = new SqlConnection { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand { Connection = cn })
                {
                    cn.Open();
                    cmd.CommandText = "SELECT id,Item,ColorId,CustomerId, qty, InCart, VendorId  FROM Product";
                    dtCustomer.Load(cmd.ExecuteReader());
                    cmd.CommandText = "SELECT ColorId,ColorText FROM Colors";
                    dtColor.Load(cmd.ExecuteReader());
                }
            }

            return (dtCustomer, dtColor);
        }
    }
}
