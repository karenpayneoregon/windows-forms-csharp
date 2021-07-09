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

namespace RadioButtonBinding
{
    public partial class Version1Form : Form
    {
        private readonly BindingSource _peopleBindingSource = new();
        private BindingList<Person> _peopleBindingList;

        public Version1Form()
        {
            InitializeComponent();

            Shown += MainForm_Shown;

            /*
             * Used in RadioButtonGroupBox.Selected property.
             * Tag can also be set in the property window of
             * each RadioButton
             */
            MrRadioButton.Tag = 1;
            MrsRadioButton.Tag = 2;
            MissRadioButton.Tag = 3;

            FemaleRadioButton.Tag = 1;
            MaleRadioButton.Tag = 2;
            OtherRadioButton.Tag = 3;

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            /*
             * Setup events to update current person
             */
            SuffixRadioGroupBox.SelectedChanged += SuffixRadioGroupBox_SelectedChanged;
            GenderRadioGroupBox.SelectedChanged += GenderRadioGroupBox_SelectedChanged;


            /*
             * Setup data source from mocked data
             */
            _peopleBindingList = new BindingList<Person>(
                DataOperations.ReadPeopleFromCommaDelimitedFile());
            
            _peopleBindingSource.DataSource = _peopleBindingList;

            /*
             * Setup data bindings to Suffix and Gender properties which are both enumerations, for
             * real applications these are int type.
             */
            SuffixRadioGroupBox.DataBindings.Add("Selected", _peopleBindingSource, 
                "Suffix");
            
            GenderRadioGroupBox.DataBindings.Add("Selected", _peopleBindingSource, 
                "Gender");

            /*
             * Setup data bindings for string properties
             */
            FirstNameTextBox.DataBindings.Add("Text", _peopleBindingSource, 
                "FirstName");
            
            LastNameTextBox.DataBindings.Add("Text", _peopleBindingSource, 
                "LastName");

            /*
             * Provides navigation of people
             */
            PeopleNavigator.BindingSource = _peopleBindingSource;

        }

        /// <summary>
        /// Set current person's gender type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenderRadioGroupBox_SelectedChanged(object sender, RadioGroupBox.SelectedChangedEventArgs e)
        {
            _peopleBindingList[_peopleBindingSource.Position].Gender = (GenderType)e.Selected;
        }

        /// <summary>
        /// Set current person's suffix type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SuffixRadioGroupBox_SelectedChanged(object sender, RadioGroupBox.SelectedChangedEventArgs e)
        {
            _peopleBindingList[_peopleBindingSource.Position].Suffix = (SuffixType) e.Selected;
        }

        /// <summary>
        /// Display all people to ensure changes done are proper
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InspectButton_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            foreach (var person in _peopleBindingList)
            {
                sb.AppendLine($"{person.Suffix,4} {person.FullName} {person.Gender}");
            }

            MessageBox.Show(sb.ToString());
        }

        /// <summary>
        /// Save all people back to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAllButton_Click(object sender, EventArgs e)
        {

            DataOperations.SaveAll(_peopleBindingList.ToList());

        }

    }
}
