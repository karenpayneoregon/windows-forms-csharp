using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DataGridViewGetCellStyle
{
    public partial class DatesForm : Form
    {
        private readonly DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle
        {
            ForeColor = Color.Transparent,
            SelectionForeColor = Color.Transparent
        };
        public DatesForm()
        {
            InitializeComponent();
            dgvRequests.CellFormatting += dgvRequestsOnCellFormatting;
        }

        private void dgvRequestsOnCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex != 1) return;
            if (dgvRequests.Rows[e.RowIndex].IsNewRow) return;

            if (!DateTime.TryParse(dgvRequests.Rows[e.RowIndex].Cells["DateColumn"].Value.ToString(), out var date)) return;
            dgvRequests.Rows[e.RowIndex].Cells["DateColumn"].Style = date.Year < 2002 ? dataGridViewCellStyle : null;
        }

        private void DatesForm_Load(object sender, EventArgs e)
        {

            dgvRequests.Rows.Add("Jim Smith", new DateTime(1999, 1, 1));
            dgvRequests.Rows.Add("jane Adams", new DateTime(2010, 1, 12));
            dgvRequests.Rows.Add("Bill North", new DateTime(2022, 1, 13));
            dgvRequests.Rows.Add("Karen Payne", new DateTime(2001, 1, 14));
        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageHelpers.LoadImageClone("Folders.png");
            File.Delete("Folders.png");
        }
    }

    public class ImageHelpers
    {
        public static Image LoadImageClone(string Path)
        {
            Bitmap imageClone = null; // the clone to be loaded to a PictureBox
            var imageOriginal = Image.FromFile(Path);

            imageClone = new Bitmap(imageOriginal.Width, imageOriginal.Height); // create clone, initially empty, same size

            using (var gr = Graphics.FromImage(imageClone)                  )
            {
                gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                gr.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
                gr.DrawImage(imageOriginal, 0, 0, imageOriginal.Width, imageOriginal.Height); //copy original image onto this surface
            
                //gr.Dispose();
            }

            imageOriginal.Dispose();

            return imageClone; 
        }
    }
}
