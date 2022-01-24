using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpersUtilitiesProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void InternetCheckButton_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                var result = await Utilities.IsConnectedToInternetAsync();
                MessageBox.Show(result ? "Available" : "Not available");
            });
        }
    }
}
