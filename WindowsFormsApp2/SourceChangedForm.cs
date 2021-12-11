using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace DataGridViewGetCellStyle
{
    public partial class SourceChangedForm : Form
    {
        public SourceChangedForm()
        {
            InitializeComponent();
        }

        private readonly BindingSource _bindingSource = new BindingSource();
        private BindingList<Item> _bindingList;

        private void SourceChangedForm_Load(object sender, EventArgs e)
        {
            List<Item> items = new List<Item>()
            {
                new Item(){ Process = true, Product = "Phone 1"},
                new Item(){ Process = false, Product = "Phone 2"},
                new Item(){ Process = true, Product = "Phone 3"},
                new Item(){ Process = false, Product = "Phone 4"},
                new Item(){ Process = false, Product = "Laptop 1"},
                new Item(){ Process = true, Product = "Laptop 2"},
            };

            _bindingList = new BindingList<Item>(items);
            _bindingSource.DataSource = _bindingList.Where(item => item.Process);

            dataGridView1.DataSource = _bindingSource;

        }

        private void MockedAddButton_Click(object sender, EventArgs e)
        {

            _bindingList.Add(new Item() { Process = true, Product = "New 1" });
            _bindingList.Add(new Item() { Process = false, Product = "New 2" }); // will not show
            _bindingList.Add(new Item() { Process = true, Product = "New 3" });

            _bindingList = new BindingList<Item>(_bindingList.Where(item => item.Process).ToList());
            _bindingSource.DataSource = _bindingList;

        }
    }

    public class Item
    {
        public bool Process { get; set; }
        public string Product { get; set; }
    }
}
