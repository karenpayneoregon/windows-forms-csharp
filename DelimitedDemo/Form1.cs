using System;
using System.Data;
using System.Windows.Forms;
using DelimitedDemo.Classes;

namespace DelimitedDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            Mocked.ReadWrite();
        }
    }
}
