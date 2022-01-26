using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccessMultiConnections.Classes;

namespace AccessMultiConnections
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var f = new CustomerForm($"Using {ConnectionHelper.CurrentConnectionString()}");
            f.ShowDialog();
        }

        private void Database1Button_Click(object sender, EventArgs e)
        {
            var source = Path.Combine(ConnectionHelper.BasePath, "Database1.accdb");
            ConnectionHelper.ChangeConnection(source);
            ConnectionStringLabel.Text = ConnectionHelper.CurrentConnectionString();
        }

        private void Database2Button_Click(object sender, EventArgs e)
        {
            var source = Path.Combine(ConnectionHelper.BasePath, "Database2.accdb");
            ConnectionHelper.ChangeConnection(source);
            ConnectionStringLabel.Text = ConnectionHelper.CurrentConnectionString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConnectionStringLabel.Text = ConnectionHelper.CurrentConnectionString();
        }
    }
}
