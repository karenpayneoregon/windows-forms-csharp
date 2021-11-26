using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equin.ApplicationFramework;
using ListboxBindings.Classes;

namespace ListboxBindings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public static List<Person> PeopleFromDatabase()
        {

            var list = new List<Person>()
            {
                new Person() { Id = 1, FirstName = "Kim", LastName = "Jones" },
                new Person() { Id = 2, FirstName = "Anne", LastName = "Smith" },
                new Person() { Id = 3, FirstName = "Mike", LastName = "Anderson" },
                new Person() { Id = 4, FirstName = "Mike", LastName = "Anders" }
            };

            return list.OrderBy(Person => Person.LastName).ToList();
        }

        private readonly BindingSource _bindingSource = new BindingSource();
        private BindingListView<Person> _bindingList;

        private void Form1_Load(object sender, EventArgs e)
        {
            _bindingList = new BindingListView<Person>(PeopleFromDatabase());
            _bindingList.Sort = "LastName";

            _bindingSource.DataSource = _bindingList;

            _bindingSource.Sort = "LastName ASC";
            listBox1.DataSource = _bindingSource;

        }
        
        private void RemoveCurrentButton_Click(object sender, EventArgs e)
        {

            if (_bindingSource.Current != null)
            {
                _bindingSource.RemoveCurrent();
            }

        }
        
        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            var person = new Person() { Id = 5, FirstName = "Joan", LastName = "Calvert" };
            
            List<Person> peopleList = new List<Person>((IEnumerable<Person>)_bindingList.DataSource) { person };

            _bindingList = new BindingListView<Person>(peopleList.OrderBy(x => x.LastName).ToList()) { Sort = "LastName" };
            _bindingSource.DataSource = _bindingList;

            int position = _bindingSource.List.IndexOf(person);
            if (position > -1)
            {
                _bindingSource.Position = position;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _bindingList.ApplyFilter(customer 
                => customer.LastName.StartsWith(textBox1.Text, StringComparison.OrdinalIgnoreCase));
        }

        private void CurrentButton_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current == null)
            {
                return;
            }

            ObjectView<Person> personView = _bindingList[_bindingSource.Position];

            Person person = personView.Object;
            Console.WriteLine();
        }
    }
}
