using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scriban;
using static Newtonsoft.Json.JsonConvert;

namespace StringInterpolationTemplating.Classes
{
    /// <summary>
    /// https://github.com/scriban/scriban
    /// Scriban is a fast, powerful, safe and lightweight scripting language and engine for .NET,
    /// which was primarily developed for text templating.
    /// </summary>
    public class TemplateScriban
    {
        public static string ScribanFromFile()
        {
            var bodyText = File.ReadAllText(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, 
                    "Services1.txt"));

            var keyValuePairs = DeserializeObject<Dictionary<string, string>>(File.ReadAllText("Management.json"));
            var resultTemplate = Template.Parse(bodyText);
            return resultTemplate.Render(new { services = keyValuePairs });

        }
    }
}
