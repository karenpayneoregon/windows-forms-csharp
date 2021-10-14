using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SingletonDemo.Classes;

namespace SingletonDemo
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();

            Shown += (sender, args) => 
                numericUpDown1.DataBindings.Add("Value", Setting.Instance, 
                    nameof(Setting.NumericUpDownValue));

            Closing += (sender, args) => 
                Setting.Instance.NumericUpDownValue = numericUpDown1.Value;
        }
    }
}
