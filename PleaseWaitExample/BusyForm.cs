using System.Windows.Forms;

namespace PleaseWaitExample
{
    public partial class BusyForm : Form
    {
        public BusyForm()
        {
            InitializeComponent();

            Closing += (sender, e) => e.Cancel = true;
            CenterToScreen();
            TopMost = true;
        }

        public void OnUpdateText(int value)
        {
            label1.Text = $"Progress {value}";
        }
    }
}
