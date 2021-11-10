using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxExperiments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string longString = new string('*', 43676) + "A1B";
            textBox1.Text = longString;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;

            label1.Text = $"textbox1.Text.Length is {textBox1.Text.Length}";

            ChildForm form = new ChildForm(textBox1.Text);
            form.ShowDialog();
        }
    }

}
