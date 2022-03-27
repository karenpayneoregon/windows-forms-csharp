using System.Collections.Generic;
using System.IO;
using Scriban;
using static Newtonsoft.Json.JsonConvert;

namespace StringInterpolationTemplating.Classes
{

    public class TemplateScriban
    {
        public static string ScribanFromFile()
        {
            var bodyText = File.ReadAllText("Services1.txt");

            var templateFileName = File.ReadAllText("Management.json");

            var keyValuePairs = DeserializeObject<Dictionary<string, string>>(templateFileName);

            var resultTemplate = Template.Parse(bodyText);
            return resultTemplate.Render(new { services = keyValuePairs });

        }
    }
}
