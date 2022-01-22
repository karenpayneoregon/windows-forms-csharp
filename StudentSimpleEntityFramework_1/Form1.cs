using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentSimpleEntityFramework_1.Data;

namespace StudentSimpleEntityFramework_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                using (var context = new Context())
                {
                    var (identifier, _) = await context.Students.FirstOrDefaultAsync();
                    MessageBox.Show($"First student id: {identifier}");
                }
            });
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                using (var context = new Context())
                {
                    var (identifier, name) = await context.Students.FirstOrDefaultAsync();
                    MessageBox.Show($"First student id: {identifier} name: {name}");
                }
            });
        }
    }
}
