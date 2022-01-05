using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace JsonDefaultValueDemo
{
    public class Mocked
    {
        private static string _fileName = "Reports.json";
        public static void Populate()
        {
            Reports reports = new Reports
            {
                List = new List<Report>
                {
                    new Report() { Name = "DWDD004", Database = "first database" },
                    new Report() { Name = "DWDD007" }
                }
            };

            string output = JsonConvert.SerializeObject(reports, Formatting.Indented);
            File.WriteAllText(_fileName, output);

        }

        public static Reports Load()
        {
            var json = File.ReadAllText(_fileName);
            return JsonConvert.DeserializeObject<Reports>(json);
        }
    }
}