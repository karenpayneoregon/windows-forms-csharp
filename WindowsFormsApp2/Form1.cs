using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2.Classes;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        
        readonly BindingList<BoxItem> _dataSource;
        
        public Form1()
        {
            InitializeComponent();

            _dataSource = new BindingList<BoxItem>(MockedData.Boxes());

            listBox1.DataSource = _dataSource;

            Flipper();
            
            radioButtonIM.CheckedChanged += RadioButtonOnCheckedChanged;
            radioButtonSI.CheckedChanged += RadioButtonOnCheckedChanged;

        }

        private void RadioButtonOnCheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender ;
            
            if (rb != null)
            {
                if (rb.Checked)
                {
                    Flipper();
                }
            }
        }

        private void Flipper()
        {
            string unitType = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString();

            Enum.TryParse(unitType, out Unit unit);
            
            for (int index = 0; index < listBox1.Items.Count; index++)
            {
                BoxItem item = _dataSource[index];
                item.Unit = unit;
            }
        }
    }
}
