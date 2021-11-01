using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoadDataGridViewProgressBar.Classes;

namespace LoadDataGridViewProgressBar
{
    public partial class BindingListForm : Form
    {
        private BindingSource _customersBindingSource = new BindingSource();
        private BindingList<Customer> _customersBindingList = new BindingList<Customer>(); 
        public BindingListForm()
        {
            InitializeComponent();
            Shown += OnShown;
        }
        private async void OnShown(object sender, EventArgs e)
        {
            await PopulateData();
        }
        private async Task PopulateData()
        {
            var (exception, customers) = await Operations.LoadCustomerList();

            if (exception == null)
            {
                _customersBindingList = null;
                _customersBindingSource = null;
                customerDataGridView.DataSource = null;

                GC.Collect();
                await Task.Delay(500);

                _customersBindingList = new BindingList<Customer>(customers);
                _customersBindingSource = new BindingSource { DataSource = _customersBindingList };
                customerDataGridView.AutoGenerateColumns = false;
                customerDataGridView.DataSource = _customersBindingSource;
                customerDataGridView.ExpandColumns(true);
            }
            else
            {
                // Decide how to handle any errors
            }
        }

        private async void LoadDataGridViewButton_Click(object sender, EventArgs e)
        {
            await PopulateData();
        }
    }
}
