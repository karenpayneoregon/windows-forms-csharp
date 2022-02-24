using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
using RazorEngine;
using RazorEngine.Templating;

namespace Email1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var emailBody = new XmlDocument();
            emailBody.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Template1.xml"));
            XmlNodeList subject = emailBody.SelectNodes("/email/subject");

            string subjectText = subject[0].InnerText.Trim();

            subjectText = subjectText.Replace("##EMAIL_SUBJECT_TEXT##", $"E-Response: Action Required: Monetary and Potential Charge");

            XmlNodeList body = emailBody.SelectNodes("/email/body");

            string bodyText = body[0].InnerText;
            bodyText = bodyText.Replace("##EMPLOYER_NAME##", "What ever");
            bodyText = bodyText.Replace("##E_RESPONSE_URL##", "www.somecompany.net");
            var test = body[0].OuterXml.ToString();
            Console.WriteLine(bodyText);
        }

        private string _codeFile = "codes.json";

        private void button2_Click(object sender, EventArgs e)
        {

            /*
             * Let's say we have gotten the first char of the user input
             */
            var codeList = new List<char>() { 'a', 'A', 'b', 'd', 'e' };

            List<WorkItem> itemList = JsonConvert.DeserializeObject<List<WorkItem>>(File.ReadAllText(_codeFile));





            var dictionary = new Dictionary<char, WorkItem>(new CharComparer());










            itemList.ForEach(x => dictionary.Add(x.Code, x));

            foreach (var input in codeList)
            {

                if (!dictionary.ContainsKey(input)) continue;
                if (dictionary[input].Used) continue;
                dictionary[input].Used = true;
            }

            foreach (KeyValuePair<char, WorkItem> item in dictionary)
            {
                Console.WriteLine($"{item.Key,-3}{item.Value.Used}");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            File.WriteAllText(_codeFile,
                JsonConvert.SerializeObject(
                    ReadItemsFromFile(), Newtonsoft.Json.Formatting.Indented));


        }

        private static List<WorkItem> ReadItemsFromFile()
        {
            List<WorkItem> list = new List<WorkItem>
            {
                new WorkItem() { Code = 'a', Tax = 100m, Used = false },
                new WorkItem() { Code = 'b', Tax = 0.0108m, Used = false },
                new WorkItem() { Code = 'c', Tax = 0.0304m, Used = false },
                new WorkItem() { Code = 'd', Tax = 0.5m, Used = false },
                new WorkItem() { Code = 'e', Tax = 300m, Used = false }
            };
            return list;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MockupEmail.Write();

            var templates = MockupEmail.Read();

            var Template2 = templates.FirstOrDefault(x => x.Name == "Template1");

            List<string> names = new List<string>() { "Mary", "Bob", "Jim" };

            foreach (var name in names)
            {
                var body = Template2
                    .Body
                    .Replace("##NAME##", name)
                    .Replace("##BODY##", $"Great news {name}");

                Console.WriteLine(body);
                Console.WriteLine();
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

public class CharComparer : IEqualityComparer<char>
{
    public bool Equals(char x, char y) => char.IsUpper(x) == char.IsUpper(y);
    public int GetHashCode(char obj) => char.ToUpper(Convert.ToChar(obj)).GetHashCode();
}

public class WorkItem
{
    public char Code { get; set; }
    public decimal Tax { get; set; }
    public bool Used { get; set; }
    public override string ToString() => $"{Tax}";
}


