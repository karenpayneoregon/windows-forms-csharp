using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DescendantsFormExample.Extensions;

namespace DescendantsFormExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            tabPage1.Descendants<Control>()
                .ToList()
                .ForEach(control => control.Enabled = EnableCheckBox.Checked);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabPage1.Enabled = !tabPage1.Enabled;
        }
    }


}
