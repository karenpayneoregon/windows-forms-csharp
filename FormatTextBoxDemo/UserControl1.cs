using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatTextBoxDemo
{
    public partial class UserControl1 : UserControl
    {
        public delegate void OnCheckChanged(CheckBox sender);
        public event OnCheckChanged OnCheckChangedEvent;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckChangedEvent?.Invoke((CheckBox)sender);
        }
    }
}
