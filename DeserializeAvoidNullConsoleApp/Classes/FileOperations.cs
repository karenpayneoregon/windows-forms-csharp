using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DeserializeAvoidNullConsoleApp.Converters;
using DeserializeAvoidNullConsoleApp.Models;

namespace DeserializeAvoidNullConsoleApp.Classes
{
    public class FileOperations
    {
        private static string _fileName = "people.json";

        public static List<Person> Read()
            => JsonSerializer.Deserialize<List<Person>>(File.ReadAllText(_fileName));

        public static void Write()
        {
            List<Person> peopleList = new()
            {
                new()
                {
                    Id = 1,
                    Country = "USA",
                    FirstName = "Karen",
                    LastName = "Payne",
                    EmailAddress = "karen@comcast.net"
                },
                new()
                {
                    Id = 2,
                    Country = null,
                    FirstName = "Bob",
                    LastName = "Smith",
                    EmailAddress = "bob@gmail.com"
                },
                new()
                {
                    Id = 3,
                    Country = "Germany",
                    FirstName = null,
                    LastName = "Smith",
                    EmailAddress = "Anne@hotmail.com"
                }
            };

            File.WriteAllText(_fileName, 
                JsonSerializer.Serialize(peopleList, 
                    JsonHelpers.JsonSerializerOptions()));

        }


    }
}
