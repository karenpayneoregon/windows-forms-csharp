using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxesInOrder
{
    public partial class Form1 : Form
    {
        private readonly List<TextBox> _textBoxes = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _textBoxes.Add(textBox1);
            _textBoxes.Add(textBox2);
            _textBoxes.Add(textBox3);

            _textBoxes.ForEach(textbox => textbox.TextChanged += OnTextChanged);
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (_textBoxes.All(texbox => int.TryParse(texbox.Text, out _)))
            {
                int.TryParse(textBox1.Text, out var v1);
                int.TryParse(textBox2.Text, out var v2);
                int.TryParse(textBox3.Text, out var v3);

                textBox4.Text = (v1 + v2 - v3).ToString();

            }
            else
            {
                textBox4.Text = "";
            }
        }
    }
}
