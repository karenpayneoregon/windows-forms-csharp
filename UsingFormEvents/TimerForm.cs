using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingFormEvents
{
    public partial class TimerForm : Form
    {
        public delegate void OnWhatEver(string sender);
        public event OnWhatEver WhatEverHandler;
        public TimerForm()
        {
            InitializeComponent();
        }

        private void WhatEverButton_Click(object sender, EventArgs e)
        {
            WhatEverHandler?.Invoke($"{sender:f}");
        }
    }
}
