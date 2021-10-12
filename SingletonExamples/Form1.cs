using System.Windows.Forms;

namespace SingletonExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            Text = "Singleton demo";
            ApplicationJobs.ValueChanged += ApplicationSettingsOnValueChanged;
            ApplicationJobs.Instance.IncrementValue();
            
        }

        private void ApplicationSettingsOnValueChanged(int value)
        {
            textBox1.Text = ApplicationJobs.Instance.Value.ToString();
        }

        private void ExecuteButton_Click(object sender, System.EventArgs e)
        {
            ApplicationJobs.Instance.Work();
        }

        private void IncrementButton_Click(object sender, System.EventArgs e)
        {
            ApplicationJobs.Instance.IncrementValue(2);
        }

        private void ResetButton_Click(object sender, System.EventArgs e)
        {
            ApplicationJobs.Instance.Reset();
        }
    }
}
