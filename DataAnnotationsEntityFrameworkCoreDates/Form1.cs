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
using DataAnnotationsEntityFrameworkCoreDates.DbContext;
using DataAnnotationsEntityFrameworkCoreDates.Models;

namespace DataAnnotationsEntityFrameworkCoreDates
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new ();
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

            var people = await GetPeople();

            _bindingSource.DataSource = people;
            dataGridView1.DataSource = _bindingSource;
        }

        private void CurrentPersonButton_Click(object sender, EventArgs e)
        {

            if (_bindingSource is null || _bindingSource.Current is null) return;

            var current = (Person1)_bindingSource.Current;
            MessageBox.Show($"{current.FirstName} {current.LastName}\n{current.BirthDateFormatted}");
        }
    }
}
