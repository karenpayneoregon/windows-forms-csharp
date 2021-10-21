using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class ImageForm : Form
    {
        public ImageForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load PictureBox with image then delete the original image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            pictureBox1.LoadClone("LearnWithKaren.png");
            pictureBox1.DeleteImage();
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Whatever", 250);

        }
        /// <summary>
        /// Populate ListView, had hard coded values which
        /// is good enough to show we can load images and then delete
        /// those images
        /// </summary>
        private void Populate()
        {
            ImageList imageList = new ImageList();

            // adjust as desire
            imageList.ImageSize = new Size(25, 25);

            // get files, in this case a folder below the app folder
            var fileNames = Directory.GetFiles(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Images"));

            foreach (var fileName in fileNames)
            {
                imageList.Images.Add(ImageHelpers.LoadBitmap(fileName));
            }

            listView1.SmallImageList = imageList;

            /*
             * Yes this is hard wired, change to match your logic
             */
            listView1.Items.Add("A", 0);
            listView1.Items.Add("B", 1);
            listView1.Items.Add("C", 2);

        }

        private void PopulateListViewButton_Click(object sender, EventArgs e)
        {
            Populate();
            /*
             * Prove we can remove all files loaded in the ListView
             */
            Directory.Delete(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images"),true);
        }
    }
}
