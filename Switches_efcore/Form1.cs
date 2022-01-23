using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Switches.Classes;
using SwitchExpressions_efcore.Extensions;

namespace SwitchExpressions_efcore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            SchoolOperations.IteratePersonGrades += IteratePersonGrades;
        }

        private void IteratePersonGrades(PersonGrades pData)
        {
            if (pData.Grade is null) return;

            ListViewItem item = new(new[]
            {
                pData.PersonID.ToString(), 
                pData.FullName, 
                pData.Grade.Value.ToString(CultureInfo.CurrentCulture), 
                pData.GradeLetter
            }) { Tag = pData };


            listView1.InvokeIfRequired( lv => lv.Items.Add(item));
        }


        private async void StudentGradesButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            await Task.Run(async () =>
            {
                await SchoolOperations.PeopleGrades(2021);
                return true;
            });

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView1.FocusedItem = listView1.Items[0];
            listView1.Items[0].Selected = true;
            ActiveControl = listView1;
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            ActiveControl = listView1;
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            var current = (PersonGrades)listView1.SelectedItems[0].Tag;

            var (id, firstName, lastName) = (PersonGrades)listView1.SelectedItems[0].Tag;
            Debug.WriteLine(id);
        }

        private void DeconstructButton_Click(object sender, EventArgs e)
        {
            ActiveControl = listView1;
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            var (id, firstName, lastName) = (PersonGrades)listView1.SelectedItems[0].Tag;
            var (id1, _, _) = (PersonGrades)listView1.SelectedItems[0].Tag;

            var (firstName1, lastName1) = (PersonGrades)listView1.SelectedItems[0].Tag;
            var (_, lastName2) = (PersonGrades)listView1.SelectedItems[0].Tag;

            ActiveControl = listView1;
        }
    }
}
