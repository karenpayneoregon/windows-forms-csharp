using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PassingDataBetweenFormsSimple
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowChildButton_Click(object sender, EventArgs e)
        {
            ChildForm childForm = new ChildForm();

            childForm.PassingData   += ChildFormOnPassingData;
            childForm.PassingNumber += ChildFormOnPassingNumber;

            try
            {
                childForm.ShowDialog();
            }
            finally
            {
                childForm.Dispose();
            }
            
        }

        private void ChildFormOnPassingNumber(int value)
        {
            numericUpDown1.Value = numericUpDown1.Value + value;
        }

        private void ChildFormOnPassingData(string text)
        {
            FirstNameTextBox.Text = string.IsNullOrWhiteSpace(text) ? 
                "(empty)" : 
                text;
        }

        private void ShowConfirmButton_Click(object sender, EventArgs e)
        {
            var confirmForm = new ConfirmForm();

            try
            {
                if (confirmForm.ShowDialog() == DialogResult.OK)
                {
                    Debug.WriteLine(confirmForm.Confirmed ? "Yes" : "No");
                }
            }
            finally
            {
                confirmForm.Dispose();
            }
        }
    }
}
