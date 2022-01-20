using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // let's say this is not empty we got data from a source
            List<Person> people = new List<Person>();


            List<Student> students = people.Select(person => new Student()
            {
                Identifier = person.Id,
                First = person.FirstName,
                Last = person.LastName,
                CityLocation = person.City
            }).ToList();

            /*
             * Now either save to json or write to a database e.g.
             * using a managed data provider or via Entity Framework.
             */
            string json = JsonConvert.SerializeObject(students, Formatting.Indented);


        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
    public class Student
    {
        public int Identifier { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string CityLocation { get; set; }

    }
}
