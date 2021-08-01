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
using CreateDynamicControls.Classes.Extensions;

namespace CreateDynamicControls
{
    public partial class Form2 : Form
    {
        private List<RadioButton> _checkedRadioButtons = new List<RadioButton>();
        public Form2()
        {
            InitializeComponent();
            
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            this.RadioButtonList().ForEach(rb =>
            {
                rb.CheckedChanged += OnCheckedChanged;
                rb.Checked = false;
                rb.Text = rb.Text.Numbers(); // original names are radioButton1, radioButton2 etc
            });

            label1.Text = "";
        }

        private void OnCheckedChanged(object sender, EventArgs e)
        {
            ProcessChecked(sender);
        }

        private void ProcessChecked(object sender)
        {
            if (!(sender is RadioButton radioButton) || !radioButton.Checked) return;

            _checkedRadioButtons = this.RadioButtonListChecked();
            
            if (_checkedRadioButtons.Count > 0)
            {
                label1.Text = string.Join(" ", _checkedRadioButtons.Select(rb => rb.Text));
            }
        }

        private void RadioButtonsCheckedButton_Click(object sender, EventArgs e)
        {
            if (_checkedRadioButtons.Any())
            {
                var checkedList = _checkedRadioButtons.Select(rb => rb).ToArray();
                var names = string.Join("\n", checkedList.Select(rb => rb.Name));

                MessageBox.Show(names);


            }
        }
    }
}
