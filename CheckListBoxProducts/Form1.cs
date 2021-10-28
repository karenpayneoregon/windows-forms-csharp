using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CheckListBoxProducts.Classes;

namespace CheckListBoxProducts
{
    public partial class Form1 : Form
    {
        private List<Product> _products = new List<Product>();
        private readonly Product _product;

        public delegate void OnProductSelected(Product product);
        public event OnProductSelected ProductSelected;

        public Form1()
        {
            InitializeComponent();
            
            Shown += OnShown;
        }
        public Form1(Product product)
        {
            InitializeComponent();
            _product = product;
            Shown += OnShown;
        }
        private void OnShown(object sender, EventArgs e)
        {

            _products = SqlServerOperations.ProductsByCategoryIdentifier(1);

            ProductCheckedListBox.DataSource = _products;
            ProductCheckedListBox.ItemCheck += ProductCheckedListBoxOnItemCheck;

            //var prodItem = _products
            //    .Select((p, index) => new { Product = p, Index = index })
            //    .FirstOrDefault(x => x.Product.ProductID == _product.ProductID);

            //if (prodItem != null)
            //{
            //    ProductCheckedListBox.SelectedIndex = prodItem.Index;
            //}
            
        }

        private void ProductCheckedListBoxOnItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int index = 0; index < ProductCheckedListBox.Items.Count; index++)
                {
                    if (index != e.Index)
                    {
                        ProductCheckedListBox.SetItemChecked(index, false);
                    }
                    else
                    {
                        ProductSelected?.Invoke(_products[e.Index]);
                    }
                }
            }
        }

        private void GetCheckedButton_Click(object sender, EventArgs e)
        {
            if (ProductCheckedListBox.CheckedItems.Count <= 0) return;
            
            List<Product> list = new List<Product>();

            for (int index = 0; index < ProductCheckedListBox.Items.Count - 1; index++)
            {
                if (ProductCheckedListBox.GetItemChecked(index))
                {
                    list.Add(_products[index]);
                }
            }

            var items = string.Join("\n",list.Select(product => product.Items));

            MessageBox.Show(items);
        }
    }
}