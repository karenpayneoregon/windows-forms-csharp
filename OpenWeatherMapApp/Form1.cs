using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using OpenWeatherMapApp.Classes;

namespace OpenWeatherMapApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void GetButton_Click(object sender, EventArgs e)
        {
            var http = new HttpClient();

            /*-------------------------------------
             * Set up to your long lat for your area
             -------------------------------------*/
            
            var url = "https://forecast.weather.gov/MapClick.php?lat=44.9429&lon=-123.0351&FcstType=json";
            
            http.DefaultRequestHeaders.Add(
                "User-Agent", 
                "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.84 Safari/537.36");
            
            var response = await http.GetAsync(url);
            
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var weather = JsonConvert.DeserializeObject<WeatherRoot>(json);


                weatherLabel.InvokeIfRequired(label =>
                {
                    label.Text = $"{weather.Current.Temperature} degrees, {weather.Current.Weather}";
                });
            }
        }
    }
}
