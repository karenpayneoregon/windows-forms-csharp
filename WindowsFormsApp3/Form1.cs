using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            ActiveControl = ShowCalendarButton;
        }

        private void ShowCalendarButton_Click(object sender, EventArgs e)
        {
            CalendarForm calendarForm = null;
            
            try
            {
                // decide to pass a date time or not
                calendarForm = DateTime.TryParse(DateTimeValueTextBox.Text, out var currentDateTime) ? 
                    new CalendarForm(currentDateTime) : 
                    new CalendarForm();

                // reposition to be next to calendar button
                calendarForm.Location = new Point(Left + (Width - 100), Bottom - 80);
                
                calendarForm.DateTimeHandler += CalendarFormOnDateTimeHandler;
                calendarForm.ShowDialog();

            }
            finally
            {
                calendarForm.DateTimeHandler -= CalendarFormOnDateTimeHandler;
                calendarForm.Dispose();
            }
        }
        // set date time
        private void CalendarFormOnDateTimeHandler(DateTime sender)
        {
            DateTimeValueTextBox.Text = $"{sender.ToString("MM-dd-yyyy")}";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
    }
}
