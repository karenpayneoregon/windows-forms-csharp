using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DescendantsExamples.Extensions;

namespace DescendantsExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetSelectionsButton_Click(object sender, EventArgs e)
        {
            var builder = new StringBuilder();

            var selectedGender = GenderGroupBox.RadioButtonChecked()?.Text ?? "Unknown";
            var selectedLevel = LevelGroupBox.RadioButtonChecked()?.Text ?? "Unknown";

            builder.AppendLine($"Gender: {selectedGender}");
            builder.AppendLine($"Level: {selectedLevel}");

            MessageBox.Show(builder.ToString());

        }
    }
}
