using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckListBoxProducts.Classes;

namespace CheckListBoxProducts
{
    public partial class Form1 : Form
    {
        private List<Product> _products = new List<Product>();

        public delegate void OnProductSelected(Product product);
        public event OnProductSelected ProductSelected;

        public Form1()
        {
            InitializeComponent();
            
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            _products = SqlServerOperations.ProductsByCategoryIdentifier(1);

            ProductCheckedListBox.DataSource = _products;
            ProductCheckedListBox.SelectedIndexChanged += OnSelectedIndexChanged;
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductCheckedListBox.GetItemCheckState(ProductCheckedListBox.SelectedIndex) == CheckState.Checked)
            {
                ProductSelected?.Invoke(_products[ProductCheckedListBox.SelectedIndex]);
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