﻿using System;
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
        public BindingSource _customersBindingSource = new BindingSource();
        public Form3()
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
            var (exception, dataTable) = await Operations.LoadCustomerDataTable();
            if (exception == null)
            {
                
                _customersBindingSource = null;
                customerDataGridView.DataSource = null;

                GC.Collect();
                await Task.Delay(500);

                _customersBindingSource = new BindingSource();

                _customersBindingSource.DataSource = dataTable;

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
