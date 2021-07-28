using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitButtonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void firstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($@"Hello from {((ToolStripMenuItem)sender).Name}");
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked");
        }
    }
}
