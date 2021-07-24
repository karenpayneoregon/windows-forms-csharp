using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePickerBlank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValueButton_Click(object sender, System.EventArgs e)
        {
            var value = DateTimePicker1.Value;

            if (DateTimePicker1.IsNullValue)
            {
                MessageBox.Show("No date");
            }
            else
            {
                MessageBox.Show(DateTimePicker1.Value.ToShortDateString());
            }
            
        }
    }
}
