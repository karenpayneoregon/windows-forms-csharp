using System.Windows.Forms;
using SimpleSingleton.Classes;

namespace SimpleSingleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadButton_Click(object sender, System.EventArgs e)
        {
            var (success, exception) = SqlOperations.GetUserInformation(usernameBox.Text, passwordBox.Text);
            
            if (success && exception == null)
            {
                var form = new Form2();

                try
                {
                    form.ShowDialog();
                    MessageBox.Show(ApplicationSettings.Instance.Info.userName);
                }
                finally
                {
                    form.Dispose();
                }
                
            }
            else
            {
                MessageBox.Show(exception.Message);
            }


        }
    }
}
