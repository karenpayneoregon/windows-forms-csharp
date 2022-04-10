using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlDemos
{
    public partial class EditForm : Form
    {
        private readonly byte[] _imageArray;

        public EditForm()
        {
            InitializeComponent();
        }
        public EditForm(byte[] bytes)
        {
            InitializeComponent();
            _imageArray = bytes;

            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            ImageConverter converter = new ImageConverter();
            pictureBox1.Image = (Image)converter.ConvertFrom(_imageArray);
        }
    }
}
