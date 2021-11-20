using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxesInOrder
{
    public partial class Form1 : Form
    {
        private readonly List<TextBox> _textBoxes = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();

            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _textBoxes.Add(textBox1);
            _textBoxes.Add(textBox2);
            _textBoxes.Add(textBox3);

            _textBoxes.ForEach(textbox => textbox.TextChanged += OnTextChanged);
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (_textBoxes.All(texbox => int.TryParse(texbox.Text, out _)))
            {
                int.TryParse(textBox1.Text, out var v1);
                int.TryParse(textBox2.Text, out var v2);
                int.TryParse(textBox3.Text, out var v3);

                textBox4.Text = (v1 + v2 - v3).ToString();

            }
            else
            {
                textBox4.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Save today's date.
            var today = DateTime.Today;

            // Calculate the age.
            DateTime birthdate = new DateTime(1956, 9, 24);

            //Console.WriteLine(birthdate.Age());
            //Console.WriteLine(birthdate.Age1());
            //var test = birthdate.Demo();

            MessageBox.Show(birthdate.CalculateAge(today));
            Console.WriteLine();



        }

        private void button2_Click(object sender, EventArgs e)
        {

            var baseText = "Textbox number ";
            for (int index = 0; index < 1000; index++)
            {
                var textBox = Controls.OfType<TextBox>().FirstOrDefault(x => x.Name == $"textBox{index}");
                if (textBox != null)
                {
                    textBox.Text = $"{baseText}{index}";
                }
            }


        }
    }

    public static class DateExtensions
    {
        public static int Age(this DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var now = (today.Year * 100 + today.Month) * 100 + today.Day;
            var dob = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;
            var age = (now - dob) / 10000;

            return age;
        }
        public static int Age1(this DateTime dateOfBirth)
        {
            var now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            var dob = int.Parse(dateOfBirth.ToString("yyyyMMdd"));
            var age = (now - dob) / 10000;

            return age;
        }

        public static (int Years, int Months, int Days) Demo(this DateTime dateOfBirth)
        {
            DateTime today = DateTime.Now;
            TimeSpan span = today - dateOfBirth;
            DateTime age = DateTime.MinValue + span;

            // Make adjustment due to MinValue equaling 1/1/1
            int years = age.Year - 1;
            int months = age.Month - 1;
            int days = age.Day - 1;
            return (years, months, days);

        }
        public static string CalculateAge(this DateTime birthDate, DateTime now)
        {
            birthDate = birthDate.Date;
            now = now.Date;

            var days = now.Day - birthDate.Day;
            if (days < 0)
            {
                var newNow = now.AddMonths(-1);
                days += (int)(now - newNow).TotalDays;
                now = newNow;
            }

            var months = now.Month - birthDate.Month;

            if (months < 0)
            {
                months += 12;
                now = now.AddYears(-1);
            }

            var years = now.Year - birthDate.Year;
            if (years == 0)
            {
                return months == 0 ? $"{days} days" : months + " months";
            }

            return $"{months} {days} {years}";
        }
    }

}
