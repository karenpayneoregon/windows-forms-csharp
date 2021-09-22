using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAnnotationsEntityFrameworkCoreDates.Classes;
using DataAnnotationsEntityFrameworkCoreDates.Data;
using DataAnnotationsEntityFrameworkCoreDates.Models;

namespace DataAnnotationsEntityFrameworkCoreDates
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new ();
        private SortableBindingList<Person1> _sortableBindingList;

        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;

            Shown += OnShown;

        }
        
        private async void OnShown(object sender, EventArgs e)
        {

            static async Task<List<Person1>> GetPeople()
            {
                return await Task.Run(async () =>
                {
                    await Task.Delay(1);
                    await using var context = new Context();
                    return context.Person1.ToList();
                });
            }

            _sortableBindingList = new SortableBindingList<Person1>(await GetPeople()) ;
            
            _bindingSource.DataSource = _sortableBindingList;
            dataGridView1.DataSource = _bindingSource;

            BirthDateDateTimePicker.DataBindings.Add("Value", _bindingSource, "BirthDate", false, 
                DataSourceUpdateMode.OnPropertyChanged);

            BirthDateDateTimePicker.ValueChanged += BirthDateDateTimePickerOnValueChanged;
        }

        private void BirthDateDateTimePickerOnValueChanged(object sender, EventArgs e)
        {
            if (_bindingSource is null || _bindingSource.Current is null) return;

            var current = (Person1)_bindingSource.Current;

            current.BirthDate = BirthDateDateTimePicker.Value;

        }
        
        private void CurrentPersonButton_Click(object sender, EventArgs e)
        {

            if (_bindingSource is null || _bindingSource.Current is null) return;

            var current = _sortableBindingList[_bindingSource.Position];

            MessageBox.Show(
                $"{current.FirstName} {current.LastName}\n" + 
                $"{current.BirthDate.Value:yyyy-MM-dd}");
        }
    }
}
