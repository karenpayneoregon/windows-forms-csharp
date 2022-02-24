using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericTextBoxApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox1.Text, @"[0-9]+(\.[0-9][0-9]?)?"))
            {
                textBox1.BackColor = Color.Red;
            }

            decimal value;
            if (!decimal.TryParse(textBox1.Text, out value))
            {
                textBox1.BackColor = Color.Red;
            }
        }
    }
    public class SpecialNumericUpDown : NumericUpDown
    {

        public SpecialNumericUpDown()
        {
            Controls[0].Hide();
            TextAlign = HorizontalAlignment.Right;
        }
        protected override void OnTextBoxResize(object source, EventArgs e)
        {
            Controls[1].Width = Width - 4;
        }


        public delegate void TriggerDelegate();
        public event TriggerDelegate TriggerEvent;
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == (Keys.Return))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                TriggerEvent?.Invoke();

                return;
            }

            base.OnKeyDown(e);
        }

    }
    public class NumericTextBox : TextBox
    {
        public Label NotificationLabel { get; set; }
        private int WM_KEYDOWN = 0x0100;
        private int WM_SYSKEYDOWN = 0x0104;
        int WM_PASTE = 0x0302;

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            //if (e.KeyChar == '-' && Text.Length > 0)
            //{
            //    e.Handled = true;
            //}
            //else
            //{
                
            //}

            base.OnKeyPress(e);

        }

        /// <summary>
        /// TODO get code to recognize minus key
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public override bool PreProcessMessage(ref Message m)
        {

            NotificationLabel.Visible = false;
            
            Keys keyCode = (Keys)m.WParam & Keys.KeyCode;
            if (m.Msg == WM_KEYDOWN)
            {

                var keys = (Keys)m.WParam.ToInt32();


                if (keyCode == Keys.OemMinus)
                {
                    //m.WParam = (IntPtr)Keys.OemMinus;
                    return false;
                }

                bool numbers = ((keys >= Keys.D0 && keys <= Keys.D9) || (keys == Keys.OemPeriod ) ||
                                (keys >= Keys.NumPad0 && keys <= Keys.NumPad9)) && ModifierKeys != Keys.Shift;
                
                bool ctrl = keys == Keys.Control;

                var ctrlZ = keys == Keys.Z && ModifierKeys == Keys.Control;
                var ctrlX = keys == Keys.X && ModifierKeys == Keys.Control;
                var ctrlC = keys == Keys.C && ModifierKeys == Keys.Control;
                var ctrlV = keys == Keys.V && ModifierKeys == Keys.Control;
                var delete   = keys == Keys.Delete;
                var backSpace  = keys == Keys.Back;
                var minus = keys == Keys.OemMinus;
                var arrows = (keys == Keys.Up) | (keys == Keys.Down) | (keys == Keys.Left) | (keys == Keys.Right);


                if (keys == Keys.Tab || keys == Keys.Enter)
                {
                    return base.PreProcessMessage(ref m);
                }

               
                if (numbers | ctrl | delete | backSpace | arrows | ctrlC | ctrlX | ctrlZ  | minus)
                {
                    return false;
                }
                else if (ctrlV)
                {
                    // handle pasting from clipboard
                    var clipboardData = Clipboard.GetDataObject();
                    var input = (string)clipboardData.GetData(typeof(string));
                    foreach (var character in input)
                    {
                        if (!char.IsDigit(character)) return true;
                    }
                    
                    return false;

                } else
                {
                    NotificationLabel.Visible = true;
                    return true;
                }
            } else
            {
                if (keyCode == Keys.Insert)
                {
                    m.WParam = (IntPtr)Keys.OemMinus;
                    return true;
                }
                return base.PreProcessMessage(ref m);
            }
        }
        /// <summary>
        /// Get int value from Text property or 0 if not an int
        /// </summary>
        [Browsable(false)]
        public int AsInt => int.TryParse(Text, out var value) ? value : 0;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_PASTE)
            {
                var clipboardData = Clipboard.GetDataObject();
                var input = (string)clipboardData?.GetData(typeof(string));
                foreach (var character in input)
                {
                    if (!char.IsDigit(character) || character == '-')
                    {
                        m.Result = (IntPtr)0;
                        return;
                    }
                }
            }

            base.WndProc(ref m);

        }
    }
}
