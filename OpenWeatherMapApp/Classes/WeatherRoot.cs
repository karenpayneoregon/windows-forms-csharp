using System;
using Newtonsoft.Json;

namespace OpenWeatherMapApp.Classes
{
    public class WeatherRoot
    {
        public string operationalMode { get; set; }
        public string srsName { get; set; }
        public DateTime creationDate { get; set; }
        public string creationDateLocal { get; set; }
        public string productionCenter { get; set; }
        public string credit { get; set; }
        public string moreInformation { get; set; }
        public Location location { get; set; }
        public Time time { get; set; }
        public Data data { get; set; }
        [JsonProperty("currentobservation")]
        public Currentobservation Current { get; set; }
    }
}