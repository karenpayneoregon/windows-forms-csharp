using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JsonSampleDataGridView
{
    public partial class DemoForm : Form
    {
        private Setting _setting = new Setting();
        // file will be in the application folder for settings
        private readonly string _settingsFileName = 
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");

        public DemoForm()
        {
            InitializeComponent();

            Shown += OnShown;
            Closing += OnClosing;
        }

        private void OnShown(object sender, EventArgs e)
        {
            if (File.Exists(_settingsFileName))
            {
                _setting = JsonConvert.DeserializeObject<Setting>(File.ReadAllText(_settingsFileName));

                if (_setting.LastRanDateTime.HasValue)
                {
                    LastRanLabel.Text = $@"Last ran {_setting.LastRanDateTime.Value:h:mm:ss tt}";
                }

                trackBar1.Value = _setting.TrackBarValue;
            }
            else
            {
                LastRanLabel.Text = "?";
            }
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            _setting.LastRanDateTime = DateTime.Now;
            _setting.TrackBarValue = trackBar1.Value;
            File.WriteAllText(_settingsFileName, JsonConvert.SerializeObject(_setting, Formatting.Indented));
        }
    }
}
