using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RadioButtonBinding.Classes;
using static RadioButtonBinding.Classes.ControlHelpers;

namespace RadioButtonBinding
{
    public partial class Version2Form : Form
    {
        private readonly BindingSource _peopleBindingSource = new();
        private BindingList<Person> _peopleBindingList;

        public Version2Form()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            _peopleBindingList = new BindingList<Person>(
                DataOperations.ReadPeopleFromCommaDelimitedFile());
            
            _peopleBindingSource.DataSource = _peopleBindingList;

            /*
             * Provides navigation of people
             */
            PeopleNavigator.BindingSource = _peopleBindingSource;

            RadioCheckedBinding(MissRadioButton, _peopleBindingSource, 
                "Suffix", SuffixType.Miss);
            
            RadioCheckedBinding(MrsRadioButton, _peopleBindingSource, 
                "Suffix", SuffixType.Mrs);
            
            RadioCheckedBinding(MrRadioButton, _peopleBindingSource, 
                "Suffix", SuffixType.Mr);

            RadioCheckedBinding(MaleRadioButton, _peopleBindingSource, 
                "Gender", GenderType.Male);
            
            RadioCheckedBinding(FemaleRadioButton, _peopleBindingSource, 
                "Gender", GenderType.Female);
            
            RadioCheckedBinding(OtherRadioButton, _peopleBindingSource, 
                "Gender", GenderType.Other);


            FirstNameTextBox.DataBindings.Add("Text", _peopleBindingSource, 
                "FirstName");
            
            LastNameTextBox.DataBindings.Add("Text", _peopleBindingSource, 
                "LastName");
        }

        private void SaveAllButton_Click(object sender, EventArgs e)
        {
            DataOperations.SaveAll(_peopleBindingList.ToList());
        }

        private void InspectButton_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            foreach (var person in _peopleBindingList)
            {
                sb.AppendLine($"{person.Suffix,4} {person.FullName} {person.Gender}");
            }

            MessageBox.Show(sb.ToString());
        }
    }
}
