using System;
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
    }
}
