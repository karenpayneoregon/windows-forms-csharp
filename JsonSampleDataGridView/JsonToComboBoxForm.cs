using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JsonSampleDataGridView
{
    public partial class JsonToComboBoxForm : Form
    {
        public JsonToComboBoxForm()
        {
            InitializeComponent();
            Shown += OnShown;
            Text = "Code sample";
        }

        private void OnShown(object sender, EventArgs e)
        {
            var fileName = 
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, 
                    "People.json");

            var json = File.ReadAllText(fileName);
            
            PeopleComboBox.DataSource = 
                JsonConvert.DeserializeObject<List<Person>>(json);
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            Person current = (Person)PeopleComboBox.SelectedItem;
            MessageBox.Show($@"{current.Identifier, -5}{current.Name}");
        }
    }

    public class Person
    {
        public int Identifier { get; set; }
        public string Name { get; set; }
        public override string ToString() => Name;
    }
}
