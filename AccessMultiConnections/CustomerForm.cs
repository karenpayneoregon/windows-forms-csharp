using System;
using System.Windows.Forms;
using AccessMultiConnections.Classes;

namespace AccessMultiConnections
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// sender is the name of the database to use
        /// </summary>
        /// <param name="sender"></param>
        public CustomerForm(string sender)
        {
            InitializeComponent();
            Text = sender;
        }
        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            customersBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(dataSet1);
        }

        private void LoadData()
        {
            customersTableAdapter.Fill(dataSet1.Customers);
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
