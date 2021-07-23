using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLightDataGridViewExport.Classes;

namespace SpreadsheetLightDataGridViewExport
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            
            _bindingSource.DataSource = DataOperations.Read();
            dataGridView1.DataSource = _bindingSource;
        }

        private void ExcelExportButton_Click(object sender, EventArgs e)
        {
            ExcelOperations.FileName = "Orders.xlsx";
            var (success, exception) = ExcelOperations.Export((DataTable) _bindingSource.DataSource);
            if (!success)
            {
                MessageBox.Show($"Failed\n{exception.Message}");
            }
        }
    }
}
