using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputDialogSpecific
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetPersonDetailsButton_Click(object sender, EventArgs e)
        {
            UserInputForm f = new UserInputForm();
            try
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(f.Person.ToString());
                }
                else
                {
                    MessageBox.Show("Cancelled");
                }
            }
            finally
            {
                f.Dispose();
            }

        }
    }
}
