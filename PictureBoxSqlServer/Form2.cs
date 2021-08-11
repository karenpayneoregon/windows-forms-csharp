using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PictureBoxSqlServer.Classes;

namespace PictureBoxSqlServer
{
    public partial class Form2 : Form
    {
        private readonly byte[] _imageByes;

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(byte[] imageBytes)
        {
            InitializeComponent();

            _imageByes = imageBytes;
            
            Shown += OnShown;
        }

        /// <summary>
        /// Note used, here to show an alternate to get an image
        /// for the PictureBox via <see cref="DataOperations.ReadCategories"/>
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
