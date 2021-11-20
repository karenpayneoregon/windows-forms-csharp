using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewCombo1
{
    public partial class MainForm : Form
    {
        private Form1 _childForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowFormButton_Click(object sender, EventArgs e)
        {
             _childForm = new Form1();
            _childForm.Show();
        }

        private void GetCurrentIdButton_Click(object sender, EventArgs e)
        {
            if (_childForm.CurrentIdentifier > -1)
            {
                var appointment = new Appointment { AppointmentID = _childForm.CurrentIdentifier };

            }
            else
            {
                // no current row
            }
        }
    }

    public class Appointment
    {
        public int AppointmentID { get; set; }
    }
}
