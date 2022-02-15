using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Windows.Forms;

namespace DataGridViewGetCellStyle
{
    public partial class SampleForm : Form
    {
        public SampleForm() { InitializeComponent(); }
        private readonly BindingSource _bindingSource = new BindingSource();
        private BindingList<Item> _bindingList;

        private void SourceChangedForm_Load(object sender, EventArgs e)
        {
            List<Item> items = new List<Item>()
            {
                new Item(){ Id = 1, Process = false, Product = "Phone 2"},
                new Item(){ Id = 2, Process = true, Product = "Phone 3"},
                new Item(){ Id = 3, Process = false, Product = "Phone 4"},
                new Item(){ Id = 4, Process = false, Product = "Laptop 1"},
                new Item(){ Id = 5, Process = true, Product = "Laptop 2"},
            };

            _bindingList = new BindingList<Item>(items);
            _bindingSource.DataSource = _bindingList;
            dataGridView1.DataSource = _bindingSource;
        }

        private void CurrentIdButton_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current != null)
            {
                MessageBox.Show($"{_bindingList[_bindingSource.Position].Id}");
            }
        }
    }

    public class Item
    {
        public int Id { get; set; }
        public bool Process { get; set; }
        public string Product { get; set; }
    }
}
