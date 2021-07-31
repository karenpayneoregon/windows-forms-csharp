using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewDataTableOracle.Classes;

namespace DataGridViewDataTableOracle
{
    public partial class Form1 : Form
    {
        private BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private async void OnShown(object sender, EventArgs e)
        {
            var results = await OracleOperations.ReadAllAsync();
            if (results.Success)
            {
                _bindingSource.DataSource = results.DataTable;
                dataGridView1.DataSource = _bindingSource;
            }
            else
            {
                MessageBox.Show(results.Exception.Message);
            }
    
        }
      
    }
}
