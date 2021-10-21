using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public static class ImageHelpers
    {
        /// <summary>
        /// Load a clone of an image
        /// </summary>
        /// <param name="fileName">Image file to load</param>
        /// <returns><see cref="Bitmap"/></returns>
        public static Bitmap LoadBitmap(string fileName)
        {
            Bitmap imageClone = null;
            var imageOriginal = Image.FromFile(fileName);

            imageClone = new Bitmap(imageOriginal.Width, imageOriginal.Height);

            Graphics gr = Graphics.FromImage(imageClone);
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            gr.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            gr.DrawImage(imageOriginal, 0, 0, imageOriginal.Width, imageOriginal.Height);
            gr.Dispose();
            imageOriginal.Dispose();

            return imageClone;
        }

        #region PictureBox specific

        public static void LoadClone(this PictureBox pictureBox, string fileName)
        {
            Bitmap imageClone = null;
            var imageOriginal = Image.FromFile(fileName);

            imageClone = new Bitmap(imageOriginal.Width, imageOriginal.Height);

            Graphics gr = Graphics.FromImage(imageClone);
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            gr.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            gr.DrawImage(imageOriginal, 0, 0, imageOriginal.Width, imageOriginal.Height);
            gr.Dispose();
            imageOriginal.Dispose();

            pictureBox.Image = imageClone; // assign the clone to picture box
            pictureBox.Tag = fileName;
        }

        public static void DeleteImage(this PictureBox pictureBox)
        {
            if (File.Exists(pictureBox.Tag.ToString()))
            {
                File.Delete(pictureBox.Tag.ToString());
            }
        }

        #endregion
        
    }
}