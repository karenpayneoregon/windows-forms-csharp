using System;
using System.Windows.Forms;

namespace PassingDataBetweenFormsSimple
{
    public partial class ChildForm : Form
    {
        public delegate void OnPassingText(string text);
        public event OnPassingText PassingData;

        public delegate void OnPassingNumber(int value);
        public event OnPassingNumber PassingNumber;

        public ChildForm()
        {
            InitializeComponent();
        }

        private void PassDataButton_Click(object sender, EventArgs e)
        {
            PassingData?.Invoke(FirstNameTextBox.Text);
            PassingNumber?.Invoke((int)numericUpDown1.Value);
        }
    }
}
