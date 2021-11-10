using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxExperiments
{
    public partial class ChildForm : Form
    {
        private readonly string _textValue;

        public ChildForm()
        {
            InitializeComponent();
        }
        public ChildForm(string textValue)
        {
            InitializeComponent();
            _textValue = textValue;
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            textBox1.Text = _textValue;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
            label1.Text = $"textbox1.Text.Length is {textBox1.Text.Length}";
        }
    }
}
