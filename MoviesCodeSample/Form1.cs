using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MoviesCodeSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            MoviesComboBox.DataSource = MovieOperations.GetMovies();
            MoviesComboBox.SelectedIndexChanged += MoviesComboBoxOnSelectedIndexChanged;
            ShowCurrentMovieImage();
        }

        private void MoviesComboBoxOnSelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCurrentMovieImage();
        }

        private void ShowCurrentMovieImage()
        {
            MoviePictureBox.Image = MovieOperations.GetMovieImage(
                ((Movie)MoviesComboBox.SelectedItem).ImageName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetFiles();
        }

        private static void GetFiles()
        {
            int? Sorter(string fileName) => int.TryParse(Regex.Match(Path.GetFileName(fileName), @"\d+").Value, out var value) ? (int?)value : null;
            var fileNamesPath1 = new[] { "C:\\DownLoads\\Path1\\image1.gif", "C:\\DownLoads\\Path1\\image11.gif", "C:\\DownLoads\\Path1\\image123.gif", "C:\\DownLoads\\Path1\\image342.gif", "C:\\DownLoads\\Path1\\image2.gif" };
            var fileNamesPath2 = new[] { "C:\\DownLoads\\Path2\\image12.gif", "C:\\DownLoads\\Path2\\image13.gif", "C:\\DownLoads\\Path2\\image129.gif", "C:\\DownLoads\\Path2\\image32.gif", "C:\\DownLoads\\Path2\\image14.gif" };
            var sortedFileNames = fileNamesPath1.Union(fileNamesPath2).ToArray().OrderBy(Sorter).ToList();

            foreach (var fileName in sortedFileNames)
            {
                Console.WriteLine(fileName);
            }
        }
    }



}
