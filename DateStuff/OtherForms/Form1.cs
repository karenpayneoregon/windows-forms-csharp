using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SqlDemos.OtherForms
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            CategoryComboBox.DataSource = DataOperations.GetCategoriesList();

        }


        public void CodeSample()
        {
            
            string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=CustomerDatabase;" +
                                      "Integrated Security=True";

            using (var cn = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand() {Connection = cn})
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[uspDummy]";
                    cmd.Parameters.Add(new SqlParameter()
                    {
                        Direction = ParameterDirection.Output, 
                        ParameterName = "@Identity", 
                        SqlDbType = SqlDbType.Int
                    });

                    cmd.Parameters.Add(new SqlParameter()
                    {
                        Direction = ParameterDirection.Output, 
                        ParameterName = "@FirstName", 
                        SqlDbType = SqlDbType.NVarChar, 
                        Size = 255
                    });

                    cmd.Parameters.Add(new SqlParameter()
                    {
                        Direction = ParameterDirection.Output, 
                        ParameterName = "@LastName", 
                        SqlDbType = SqlDbType.NVarChar, 
                        Size = 255
                    });

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    Console.WriteLine(cmd.Parameters["@Identity"].Value);
                    Console.WriteLine(cmd.Parameters["@FirstName"].Value);
                    Console.WriteLine(cmd.Parameters["@LastName"].Value);
                }

            }
        }


  

    }
    public class Categories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public override string ToString() => CategoryName;
    }
}
