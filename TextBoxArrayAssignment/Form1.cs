using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxArrayAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly string[] _strings =
        {
            "One", 
            "Two", 
            "Three", 
            "Four", 
            "Five", 
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten"
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            var textBoxes = groupBox1.Controls.OfType<TextBoxCustom>().Where(x => x.Identifier <= _strings.Length).ToList();

        }

        private void Solution1()
        {
            var textBoxes = groupBox1.Controls.OfType<TextBoxCustom>().ToList();

            for (int index = 0; index < _strings.Length; index++)
            {
                var targetControl = textBoxes
                    .FirstOrDefault(textBoxCustom => textBoxCustom.Identifier == index + 1);

                if (targetControl != null)
                {
                    targetControl.Text = _strings[index];
                }
            }
        }
    }
}
