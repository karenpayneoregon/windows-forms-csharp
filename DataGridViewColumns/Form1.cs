using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewColumns.Classes;

namespace DataGridViewColumns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            DataTable dt = LoadData();
            dataGridView1.DataSource = dt;

            foreach (var column in FileOperations.Columns.Where(column => dt.Columns.Contains(column.Name)))
            {
                dt.Columns[column.Name].ColumnName = column.DisplayName;
            }
        }


        private DataTable LoadData()
        {
            var table = new DataTable();

            table.Columns.Add("A1", typeof(DateTime));
            table.Columns.Add("A4", typeof(string));
            table.Columns.Add("A10", typeof(string));


            table.Rows.Add(DateTime.Now, "Hello", "World");
            table.Rows.Add(DateTime.Now.AddDays(-1), "Hi", "There");

            return table;
        }
    }
}
