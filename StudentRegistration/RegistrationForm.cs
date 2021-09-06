using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentRegistration.Classes;

namespace StudentRegistration
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            AppointmentDetailLabel.Id = 12;
            AppointmentDetailLabel.LinkClicked += ShowAppointmentDetailLabelOnLinkClicked;
        }

        private void ShowAppointmentDetailLabelOnLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AppointmentDetailLabel.Id.HasValue)
            {
                // use AppointmentDetailLabel.Id.Value
            }
            else
            {
                // Id not set
            }
            
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var genderItem = Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
            
            if (genderItem != null)
            {
                var person = new Person
                {
                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    Gender = Convert.ToInt32(genderItem.Tag) == 1,
                    BirthDay = BirthDateDateTimePicker.Value,
                    PhoneNumber = ContactNumberTextBox.Text
                };
                
                var (success, exception) = SqlOperations.Add(person);
                MessageBox.Show(success ? 
                    $"New key: {person.Id}" : 
                    $"Failed to add person\n{exception.Message}");
            }
            else
            {
                MessageBox.Show("Gender is required");
            }
        }
    }
}
