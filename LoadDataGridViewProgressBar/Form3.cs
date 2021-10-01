using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoadDataGridViewProgressBar.Classes;

namespace LoadDataGridViewProgressBar
{
    public partial class Form3 : Form
    {
        public readonly BindingSource _customersBindingSource = new BindingSource();
        public Form3()
        {
            InitializeComponent();

            Shown += OnShown;
        }

        private async void OnShown(object sender, EventArgs e)
        {
            var (exception, dataTable) = await Operations.LoadCustomerData();
            _customersBindingSource.DataSource = dataTable;
            customerDataGridView.DataSource = _customersBindingSource;
            customerDataGridView.ExpandColumns(true);



        }

    
    }
}
