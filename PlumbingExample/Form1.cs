using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PlumbingExample
{
    public partial class Form1 : Form
    {
        private readonly List<CheckBox> _checkBoxes;
        private double _serviceCharge = 5d;

        public Form1()
        {
            InitializeComponent();
            Shown += OnShown;
            _checkBoxes = Controls.OfType<CheckBox>().ToList();
        }

        private void OnShown(object sender, EventArgs e)
        {
            Service1CheckBox.Tag = new Service() { Id = 1, Name = "Service 1", Cost = 45.00d };
            Service2CheckBox.Tag = new Service() { Id = 2, Name = "Service 2", Cost = 55.00d };
            Service3CheckBox.Tag = new Service() { Id = 3, Name = "Service 3", Cost = 65.00d };

            _checkBoxes.ForEach(x => x.CheckStateChanged += CheckBoxOnCheckedChanged);

            serviceTotalText.Text = "$0.00";
        }

        private void CheckBoxOnCheckedChanged(object sender, EventArgs e)
        {
            var total = _checkBoxes
                .Where(checkBox => checkBox.Checked)
                .Select(checkBox => ((Service)checkBox.Tag).Cost + _serviceCharge)
                .Sum();

            serviceTotalText.Text = total.ToString("C");
            serviceTotalText.Tag = total;
        }
    }
}
