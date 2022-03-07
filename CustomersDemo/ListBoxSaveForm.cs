using System;
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
        
        private readonly BindingSource _customersBindingSource = new BindingSource();
        
        
        public ListBoxSaveForm()
        {
            InitializeComponent();

            Shown += OnShown;

            comboBox1.DataSource = Mocked.List;
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
                Controls.OfType<TextBox>().ToList().ForEach(x => x.Text = "");
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

            for (int index = 0; index < _customersBindingList.Count; index++)
            {
                _customersBindingList[index].CustomerIdentifier = index +1;
            }
            
            var (success, exception) = _customersBindingList.JsonToFile("CustomersSaved.json");
            MessageBox.Show(exception is null ? "Saved" : $"Failed\n{exception.Message}");
        }
    }

public class Example
{
    public int Id { get; set; }
    public string Nama { get; set; }
    public override string ToString() => Nama;
}

public class Mocked
{
    public static List<Example> List = new()
    {
        new () {Id = 1, Nama = "First"},
        new () {Id = 2, Nama = "Second"},
    };
}
}
