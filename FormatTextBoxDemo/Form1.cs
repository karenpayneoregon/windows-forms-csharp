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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DemoControl.OnCheckChangedEvent += DemoControlCheckChanged;
            DemoControl.checkBox1.CheckStateChanged += CheckBox1OnCheckStateChanged;
        }

        private void CheckBox1OnCheckStateChanged(object sender, EventArgs e)
        {
            
        }

        private void DemoControlCheckChanged(CheckBox sender)
        {
            MessageBox.Show($"{sender.Checked}");
        }
    }

    public class FormattedTextBox : TextBox
    {
        protected override void OnEnter(EventArgs e)
        {
            SelectAll();

            base.OnEnter(e);
        }

        [Category("Behavior")]
        [Description("Pad text with")]
        public int PadWith { get; set; }

        protected override void OnLeave(EventArgs e)
        {
            var temp = Text.Length > PadWith ? Text.Substring(0, PadWith -1) : Text;

            if (int.TryParse(temp, out var value))
            {
                Text = value.ToString().PadLeft(PadWith, '0');
            }

            base.OnLeave(e);
        }
    }
}
