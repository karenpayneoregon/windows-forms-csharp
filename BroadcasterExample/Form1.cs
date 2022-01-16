using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BroadcasterExample.Classes;
using static BroadcasterExample.Classes.Factory;

namespace BroadcasterExample
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        private Form2 _form2 = new Form2();
        public Form1()
        {
            InitializeComponent();

            _bindingSource.DataSource = new List<Person>()
            {
                new Person() { Id = 1, FirstName = "Karen", LastName = "Payne" },
                new Person() { Id = 2, FirstName = "Jim", LastName = "Adams" },
                new Person() { Id = 3, FirstName = "Mary", LastName = "Jones" }
            };

            listBox1.DataSource = _bindingSource;
        }

        private void OpenChildFormButton_Click(object sender, EventArgs e)
        {

            _form2 = new Form2();
            _form2.Show();
            _form2.Top = Top;
            _form2.Left = Left + Width + 10;
        }

        private void PassButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                Broadcaster().Broadcast((Person) _bindingSource.Current, this);
            }
        }
    }
}
