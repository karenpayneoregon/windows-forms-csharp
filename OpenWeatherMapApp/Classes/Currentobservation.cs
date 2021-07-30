using Newtonsoft.Json;

namespace OpenWeatherMapApp.Classes
{
    public class Currentobservation
    {
        public string id { get; set; }
        public string name { get; set; }
        public string elev { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string Date { get; set; }
        [JsonProperty("Temp")]
        public string Temperature { get; set; }
        public string Dewp { get; set; }
        public string Relh { get; set; }
        public string Winds { get; set; }
        public string Windd { get; set; }
        public string Gust { get; set; }
        public string Weather { get; set; }
        public string Weatherimage { get; set; }
        public string Visibility { get; set; }
        public string Altimeter { get; set; }
        public string SLP { get; set; }
        [JsonProperty("timezone")]
        public string TimeZone { get; set; }
        public string state { get; set; }
        public string WindChill { get; set; }
    }
}