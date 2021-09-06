﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomersDemo.Classes;

namespace CustomersDemo
{
    public partial class ListBoxSaveForm : Form
    {
        private BindingList<Customer> _customersBindingList;
        private readonly BindingSource _customersBindingSource = new();
        public ListBoxSaveForm()
        {
            InitializeComponent();

            Shown += OnShown;
        }

        private void OnShown(object? sender, EventArgs e)
        {
            _customersBindingList = new BindingList<Customer>();
            _customersBindingSource.DataSource = _customersBindingList;
            CustomersListBox.DataSource = _customersBindingSource;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FirstNameTextBox.Text) && !string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                _customersBindingList.Add(new Customer() { FirstName = FirstNameTextBox.Text, LastName = LastNameTextBox.Text });
            }
        }

        private void EditCurrentButton_Click(object sender, EventArgs e)
        {
            if (_customersBindingSource.Count > 0 && CustomersListBox.SelectedIndex > -1)
            {
                if (!string.IsNullOrWhiteSpace(FirstNameTextBox.Text) && !string.IsNullOrWhiteSpace(LastNameTextBox.Text))
                {
                    _customersBindingList[CustomersListBox.SelectedIndex].FirstName = FirstNameTextBox.Text;
                    _customersBindingList[CustomersListBox.SelectedIndex].LastName = LastNameTextBox.Text;
                }
            }
        }

        private void JsonSaveButton_Click(object sender, EventArgs e)
        {
            if (_customersBindingList.Count <= 0) return;
            var (success, exception) = _customersBindingList.JsonToFile("CustomersSaved.json");
            MessageBox.Show(exception is null ? "Saved" : $"Failed\n{exception.Message}");
        }
    }
}