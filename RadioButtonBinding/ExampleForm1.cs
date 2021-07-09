using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RadioButtonBinding.LanguageExtensions;

namespace RadioButtonBinding
{
    public partial class ExampleForm1 : Form
    {
        public ExampleForm1()
        {
            InitializeComponent();
        }

        private void GetSelectedChoiceOnFormButton_Click(object sender, EventArgs e)
        {
            
            var selectedRadioButton = Controls.OfType<RadioButton>()
                .FirstOrDefault(radioButton => radioButton.Checked);
            
            MessageBox.Show(selectedRadioButton is null ? 
                "None selected" : 
                $"{selectedRadioButton.Text}");
        }

        private void GetSelectedChoiceInGroupBoxButton_Click(object sender, EventArgs e)
        {
            
            var selectedRadioButton = SuffixRadioGroupBox.Controls.OfType<RadioButton>()
                .FirstOrDefault(radioButton => radioButton.Checked);

            MessageBox.Show(selectedRadioButton is null ?
                "None selected" :
                $"{selectedRadioButton.Text}");
        }

        private void ClearCheckedButton_Click(object sender, EventArgs e)
        {

            foreach (var button in SuffixRadioGroupBox.Controls.OfType<RadioButton>())
            {
                button.Checked = false;
            }
            
        }
    }
}
