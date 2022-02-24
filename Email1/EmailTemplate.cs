using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Email1
{
    public class EmailTemplate
    {
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    public class MockupEmail
    {
        public static string FileName => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates.json");

        public static List<EmailTemplate> Read()
        {
            return  JsonConvert.DeserializeObject<List<EmailTemplate>>(File.ReadAllText(FileName));
        }
        public static void Write()
        {
            List<EmailTemplate> list = new List<EmailTemplate>
            {
                new EmailTemplate()
                {
                    Name = "Template1", 
                    Subject = "Monthly news letter", 
                    Body = "<style>.fg-white {color: crimson;}</style><p>Hello ##NAME##</p><p class=\"fg-white\">##BODY##</p>"
                },
                new EmailTemplate()
                {
                    Name = "Template2",
                    Subject = "Notice of intention",
                    Body = "<p>Hello ##NAME##</p><p class=\"fg-white\">##BODY##</p>"
                }
            };

            File.WriteAllText(FileName, JsonConvert.SerializeObject(list, Formatting.Indented));
        }
    }
}
