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
    public partial class CalendarForm : Form
    {
        public delegate void OnSelectDateTime(DateTime sender);
        public event OnSelectDateTime DateTimeHandler;
        
        public CalendarForm()
        {
            InitializeComponent();
        }
        public CalendarForm(DateTime sender)
        {
            InitializeComponent();
            monthCalendar1.SetDate(sender);
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            DateTimeHandler?.Invoke(monthCalendar1.SelectionRange.Start);
            Close();
        }
    }
}
