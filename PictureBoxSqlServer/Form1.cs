using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PictureBoxSqlServer.Classes;

namespace PictureBoxSqlServer
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _categoriesBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            _categoriesBindingSource.DataSource = DataOperations.ReadCategoriesList();
            _categoriesBindingSource.PositionChanged += CategoriesBindingSourceOnPositionChanged;
            
            CategoryListBox.DataSource = _categoriesBindingSource;
            
            SetPicture();
        }

        private void CategoriesBindingSourceOnPositionChanged(object sender, EventArgs e)
        {
            SetPicture();
        }

        private void SetPicture()
        {
            pictureBox1.Image = ImageHelpers.ByteArrayToImage(((Categories) _categoriesBindingSource.Current).Picture);
        }

        private void ShowFormButton_Click(object sender, EventArgs e)
        {
            var imageArray = pictureBox1.Image.ToBytes();

            var f = new Form2(imageArray);

            try
            {
                f.ShowDialog();
            }
            finally
            {
                f.Dispose();
            }
        }
    }
}
