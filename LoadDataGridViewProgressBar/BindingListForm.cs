﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoadDataGridViewProgressBar.Classes;

namespace LoadDataGridViewProgressBar
{
    public partial class BindingListForm : Form
    {
        private BindingSource _customersBindingSource = new BindingSource();
        private BindingList<Customer> _customersBindingList = new BindingList<Customer>(); 
        private BindingList<Customer> _customersBindingListFiltered = new BindingList<Customer>(); 
        public BindingListForm()
        {
            InitializeComponent();
            Shown += OnShown;
        }
        private async void OnShown(object sender, EventArgs e)
        {
            await PopulateData(true);
        }

        private async Task PopulateData(bool firstTime = false)
        {
            var (exception, customers) = await Operations.LoadCustomerList();

            if (exception == null)
            {
                if (!firstTime)
                {
                    _customersBindingList = null;
                    _customersBindingSource = null;
                    customerDataGridView.DataSource = null;

                    GC.Collect();
                }

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

        private void FilterButton_Click(object sender, EventArgs e)
        {

            /*
             * If CompanyNameFilterTextBox.Text is empty, filter is removed
             */
            _customersBindingListFiltered = new BindingList<Customer>(
                _customersBindingList.Where(product =>
                    product.CompanyName.StartsWith(CompanyNameFilterTextBox.Text, StringComparison.OrdinalIgnoreCase)).ToList());

            _customersBindingSource.DataSource = _customersBindingListFiltered;
            customerDataGridView.DataSource = _customersBindingSource;



        }

    }

    public static class MyExtensions
    {
        public static string TrimLastCharacter(this String str) 
            => string.IsNullOrEmpty(str) ? str : str.TrimEnd(str[str.Length - 1]);
    }
}
