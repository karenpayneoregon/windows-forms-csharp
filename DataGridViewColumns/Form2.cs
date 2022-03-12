using System;
using System.Data;
using System.Windows.Forms;

namespace DataGridViewColumns
{
    public partial class Form2 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form2()
        {

            InitializeComponent();

            _bindingSource.DataSource = MockedData();

            dataGridView1.DataSource = _bindingSource;
        }

        public DataTable MockedData()
        {
            var dt = new DataTable();

            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("TransactionDate", typeof(DateTime));

            dt.Rows.Add(1, new DateTime(2022, 9, 3));
            dt.Rows.Add(1, new DateTime(2022, 6, 3));
            dt.Rows.Add(1, new DateTime(2022, 10, 1));
            dt.Rows.Add(1, new DateTime(2022, 9, 11));
            dt.Rows.Add(1, new DateTime(2022, 9, 12));

            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // replace the two vars with DateTimePickers
            var lowDate = new DateTime(2022, 9, 1);
            var highDate = new DateTime(2022, 9, 12);

            if (string.IsNullOrWhiteSpace(_bindingSource.Filter))
            {
                _bindingSource.Filter = $"TransactionDate >= '{lowDate}' AND TransactionDate <= '{highDate}'";
            }
            else
            {
                _bindingSource.Filter = "";
            }
            
        }
    }


}
