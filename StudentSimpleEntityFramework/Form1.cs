using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StudentSimpleEntityFramework.Data;

namespace StudentSimpleEntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void FirstOrDefaultIdButton_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                await using (var context = new Context())
                {
                    var (identifier, _) = await context.Student.FirstOrDefaultAsync();
                    MessageBox.Show($"First student id: {identifier}");
                }
            });
        }

        private async void FirstOrDefaultIdNameButton_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                await using (var context = new Context())
                {
                    var (identifier, name) = await context.Student.FirstOrDefaultAsync();
                    MessageBox.Show($"First student id: {identifier}\nName: {name}");
                }
            });
        }

        private async void FindByIdButton_Click(object sender, EventArgs e)
        {
            int studentIdentifier = 1;

            await Task.Run(async () =>
            {
                await using (var context = new Context())
                {
                    var (identifier, name) = await context.Student.FindAsync(studentIdentifier);
                    MessageBox.Show($"First student id: {identifier}\nName: {name}");
                }
            });
        }
    }
}
