using System;
using System.Windows.Forms;
using PictureBoxSqlServer_efcore.Classes;

namespace PictureBoxSqlServer_efcore
{
    public partial class Form2 : Form
    {
        private readonly byte[] _imageByes;

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(byte[] imageBytes, string categoryName)
        {
            InitializeComponent();

            _imageByes = imageBytes;
            
            Text = categoryName;
            
            Shown += OnShown;
        }

        /// <summary>
        /// Note used, here to show an alternate to get an image
        /// </summary>
        /// <param name="categoryIdentifier">Valid category primary key</param>
        public Form2(int categoryIdentifier)
        {
            InitializeComponent();

            // write code to get image from database

            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageHelpers.ByteArrayToImage(_imageByes);
        }
    }
}
