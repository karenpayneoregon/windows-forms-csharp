using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RadioButtonBinding.LanguageExtensions;

namespace RadioButtonBinding
{
#nullable disable
    public partial class ExamplesForm2 : Form
    {
        public ExamplesForm2()
        {
            InitializeComponent();
            
            Shown += OnShown;
        }

        /// <summary>
        /// Clear default selection for radio buttons and
        /// subscribe to CheckChanged event for all radio buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnShown(object sender, EventArgs e)
        {
            ClearSuffixSelection();
            
            this.RadioButtonList().ForEach(rb => rb.CheckedChanged += (o, args) =>
            {
                if (rb?.Checked == true)
                {
                    CurrentSelectionLabel.Text = $@"You selected: {rb.Text}";
                }

            });
            
        }

        private void ClearSuffixSelection()
        {
            this.RadioButtonList().ForEach(rb => rb.Checked = false);
            CurrentSelectionLabel.Text = @"(none)";
        }

        private void GetSelectedChoiceButton_Click(object sender, EventArgs e)
        {
            RadioButton selectedSuffix = SuffixRadioGroupBox.RadioButtonChecked();
            
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse - untrue
            MessageBox.Show(selectedSuffix is null ? 
                "Please select an option" : 
                selectedSuffix.Text);
        }

        private void ClearRadioSelectionButton_Click(object sender, EventArgs e)
        {
            ClearSuffixSelection();
        }
    }
}
