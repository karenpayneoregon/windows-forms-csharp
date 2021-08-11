using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectorLibrary;

namespace TestSingletonConnection
{
    public partial class Form1 : Form
    {
        private SqlDataAdapter _sqlDataAdapter;
        public Form1()
        {
            InitializeComponent();

            /*
             * Let's say in a real app the connection string comes from an encrypted app.config or appsettings.json
             */
            SqlServerConnections.Instance.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=NorthWind2020;Integrated Security=True";
            _sqlDataAdapter = new SqlDataAdapter("TODO", SqlServerConnections.Instance.Connection());
            
            

            
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            
            using (var cmd = new SqlCommand() {Connection =  SqlServerConnections.Instance.Connection()})
            {
                cmd.CommandText = "SELECT CountryIdentifier FROM Countries";

                DataTable dataTable = new DataTable();
                dataTable.Load(cmd.ExecuteReader());
                label1.Text = dataTable.Rows.Count.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            
            using (var cn = SqlServerConnections.Instance.Connection())
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = "SELECT CountryIdentifier FROM Countries";

                    DataTable dataTable = new DataTable();
                    dataTable.Load(cmd.ExecuteReader());
                    label2.Text = dataTable.Rows.Count.ToString();

                }
            }
        }
    }
}
