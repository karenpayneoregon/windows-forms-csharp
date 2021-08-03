using System;
using System.ComponentModel;
using System.Windows.Forms;
using SimpleSingleton.Classes;

namespace SimpleSingleton
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
            Closing += OnClosing;
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            ApplicationSettings.Instance.Info.userName = "Anne";
        }

        
        private void GetUserInfoButton_Click(object sender, EventArgs e)
        {
            var userName = ApplicationSettings.Instance.Info.userName;
            MessageBox.Show(userName);
        }
    }
}
