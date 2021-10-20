using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBoxProducts
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenForm1Button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var f = new Form1(new Product() {ProductID = 24});

            try
            {
                f.ProductSelected += ProductSelected;
                f.Top = Top;
                f.Left = (Left + Width) + 10;
                f.ShowDialog();
            }
            finally
            {
                f.Dispose();
                f.ProductSelected -= ProductSelected;
            }
        }

        private void ProductSelected(Product product)
        {
            listBox1.Items.Add(product.ProductName);
        }
    }
}
