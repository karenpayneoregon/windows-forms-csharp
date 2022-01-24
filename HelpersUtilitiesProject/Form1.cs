using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelpersUtilitiesProject.Classes;

namespace HelpersUtilitiesProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TimerHelper.Message += OnMessage;

            Shown += OnShown;

        }

        private void OnShown(object sender, EventArgs e)
        {
            label1.Text = "";
            TimerHelper.Start();
        }

        private void OnMessage(string message) => 
            label1.InvokeIfRequired(x => x.Text = message);
    }
}
