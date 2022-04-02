using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FileWatcherExample
{
    public partial class Form1 : Form
    {
        private readonly FileOperations _fileOperations = 
            new FileOperations("C:\\OED", "C:\\OED\\ZipFileHome", "*.*");
        
        public Form1()
        {
            InitializeComponent();
            Closing += OnClosing;
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            _fileOperations.Stop();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _fileOperations.Start();
        }

       
        private void StopButton_Click(object sender, EventArgs e)
        {
            //_fileOperations.Stop();

            
        }
    }
}
