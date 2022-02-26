using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputDialogSpecific
{
    public partial class UserInputForm : Form
    {
        public readonly Person Person = new Person();
        public UserInputForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FirstNameTextBox.Text) & !string.IsNullOrWhiteSpace(LastNameTextBox.Text) & BirthDateTimePicker.Value < DateTime.Now)
            {
                Person.FirstName = FirstNameTextBox.Text;
                Person.LastName = LastNameTextBox.Text;
                Person.BirthDate = BirthDateTimePicker.Value;
                DialogResult = DialogResult.OK;
            }
            else
            {
                // present user with a dialo
            }

        }
    }
}
