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
using DeconstructCodeSamples.Classes;
using DeconstructCodeSamples.Extensions;
using Switches.Classes;

namespace DeconstructCodeSamples
{
    public partial class DeconstructForm : Form
    {
        public DeconstructForm()
        {
            InitializeComponent();

            Shown += OnShown;
        }

        /// <summary>
        /// Load students into listbox
        /// </summary>
        private async void OnShown(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                var students = await SchoolOperations.GetStudents();
                listBox1.InvokeIfRequired(lb => lb.DataSource = students);
            });
        }

        /// <summary>
        /// How a developer typically shows information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConventionButton_Click(object sender, EventArgs e)
        {
            if (listBox1.DataSource is null) return;
            var current = (PersonEntity)listBox1.SelectedItem;
            // ReSharper disable once LocalizableElement
            MessageBox.Show($"{current.PersonID}\n{current.FirstName}\n{current.LastName}");
        }

        /// <summary>
        /// Deconstruct to a custom TaskDialog
        /// </summary>
        private void DeconstructIdFirstLastButton_Click(object sender, EventArgs e)
        {
            if (listBox1.DataSource is null) return;
            Dialogs.Information(this, (PersonEntity)listBox1.SelectedItem,"Cool");
        }
        /// <summary>
        /// Deconstruct to a regular MessageBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeconstructIdLastButton_Click(object sender, EventArgs e)
        {
            if (listBox1.DataSource is null) return;
            var (id, _, last) = (PersonEntity)listBox1.SelectedItem;
            // ReSharper disable once LocalizableElement
            MessageBox.Show($"{id} for {last}");
        }
    }
}
