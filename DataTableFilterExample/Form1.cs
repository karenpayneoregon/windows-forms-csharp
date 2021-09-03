using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DataTableFilterExample
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = 
            new BindingSource();
        
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            _bindingSource.DataSource = LoadDataTable();
            dataGridView1.DataSource = _bindingSource;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            DataTable table = 
                (
                    from dataRow in ((DataTable)_bindingSource.DataSource).AsEnumerable() 
                    where Regex.IsMatch(dataRow.Field<string>("Mark"), @"^CB\d+$") 
                    select dataRow
                )
                .ToArray()
                .CopyToDataTable();
            
            table.Columns["id"].ColumnMapping = MappingType.Hidden;
            
            _bindingSource.DataSource = table;
            
        }

        private static DataTable LoadDataTable()
        {
            var dt = new DataTable();

            dt.Columns.Add(new DataColumn()
            {
                ColumnName = "Id", 
                DataType = typeof(int), 
                AutoIncrement = true, 
                AutoIncrementSeed = 1,
                ColumnMapping = MappingType.Hidden
            });
            
            dt.Columns.Add(new DataColumn("Mark", typeof(string)));
            dt.Columns.Add(new DataColumn("Value1", typeof(int)));
            dt.Columns.Add(new DataColumn("Value2", typeof(int)));

            dt.Rows.Add(null,"CBY1", 10, 50);
            dt.Rows.Add(null,"CB1", 20, 200);
            dt.Rows.Add(null,"CB2", 30, 300);
            
            return dt;
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current != null)
            {
                var row = ((DataRowView) _bindingSource.Current).Row;

                MessageBox.Show($"Id:{row.Field<int>("id"),6:D3}\nValue1:{row.Field<int>("Value1"),6:D3}");
            }
            else
            {
                MessageBox.Show("No current row");
            }
        }
    }
}
