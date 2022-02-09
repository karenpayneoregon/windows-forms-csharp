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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenTimerForm_Click(object sender, EventArgs e)
        {
            TimerForm form = new TimerForm();
            form.WhatEverHandler += FormOnWhatEverHandler;
            form.ShowDialog();
        }

        private void FormOnWhatEverHandler(string sender)
        {
            label1.Text = sender;
        }
    }
}
