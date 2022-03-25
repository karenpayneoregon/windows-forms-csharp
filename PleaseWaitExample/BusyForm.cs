using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
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

        public async void OnUpdateText(int value)
        {
            label1.InvokeIfRequired(label => label.Text = $"Progress {value}");
            await Task.Delay(1000);
            Console.WriteLine(value);
        }
    }
    public static class Extensions
    {
        public static void InvokeIfRequired<T>(this T control, Action<T> action) where T : ISynchronizeInvoke
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => action(control)), null);
            }
            else
            {
                action(control);
            }
        }
    }
}
