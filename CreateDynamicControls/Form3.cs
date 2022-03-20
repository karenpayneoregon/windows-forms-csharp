using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreateDynamicControls.Classes;

namespace CreateDynamicControls
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            ControlHelper.ButtonClick += OnButtonClick;
            ControlHelper.Initialize(flowLayoutPanel1, 20, 30, 10, 50);

            for (int index = 0; index < 250; index++)
            {
                ControlHelper.CreateButton();
            }

        }

        private void OnButtonClick(object sender)
        {
            textBox1.Text = ((Button)sender).Tag.ToString();
        }
    }
}
