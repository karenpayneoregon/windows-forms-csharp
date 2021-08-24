using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CustomersDemo
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Customer> _customersBindingList;
        public Form1()
        {
            InitializeComponent();

            _customersBindingList = new BindingList<Customer>(MockedData.Customers());
            listBoxCustomers.DataSource = _customersBindingList;
        }

        private void RemoveCurrentButton_Click(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedIndex > -1)
            {
                _customersBindingList.RemoveAt(listBoxCustomers.SelectedIndex);
            }

            RemoveCurrentButton.Enabled = listBoxCustomers.SelectedIndex > -1;
        }
    }
}
