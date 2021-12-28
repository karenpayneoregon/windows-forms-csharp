using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewCheckedSum
{
    public partial class DataGridViewCalcForm : Form
    {
        public DataGridViewCalcForm()
        {
            InitializeComponent();

            Shown += OnShown;

        }

        private void OnShown(object sender, EventArgs e)
        {
            
            dataGridView1.AutoGenerateColumns = false;

            DataTable table = new DataTable();
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Qty", typeof(int));
            table.Columns.Add("Price", typeof(decimal));
            table.Columns.Add("Total", typeof(decimal));

            table.Columns["Total"].Expression = "Qty * Price";

            table.Rows.Add("First item", 2, 60);
            table.Rows.Add("Second item", 2, 50);
            table.Rows.Add("Third item", 1, 20);

            dataGridView1.DataSource = table;

            CalculateTotal();
        }

        private void CalculateTotal()
        {
            TotalLabel.Text = ((DataTable)dataGridView1.DataSource).AsEnumerable().Sum(row => row.Field<decimal>("Total")).ToString("C");
        }
    }
}
