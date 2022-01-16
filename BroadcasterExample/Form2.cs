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
using BroadcasterExample.Interfaces;
using static BroadcasterExample.Classes.Factory;

namespace BroadcasterExample
{
    public partial class Form2 : Form, IListener
    {
        private readonly BindingSource _bindingSource = new BindingSource();
        public Form2()
        {
            InitializeComponent();

            Broadcaster().AddListener(this);

            listBox1.DataSource = _bindingSource;

            Closing += Form2_Closing;
        }

        private void Form2_Closing(object sender, CancelEventArgs e)
        {
            Broadcaster().RemoveListener(this);
        }

        public void OnListen(Person person, Form sender)
        {
            if (sender is Form1)
            {
                _bindingSource.Add(person);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
        }
    }
}
