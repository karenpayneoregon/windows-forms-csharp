using System;
using System.Collections.Generic;
using System.Linq;

namespace InterpolationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var person in Mocking.People)
            {
                Console.WriteLine($"{person.Id,-5:D3}{person,-25}");
                foreach (var hobby in person.Hobbies)
                {
                    Console.WriteLine($"\t{hobby.ID:D2}{hobby,30}");
                }
            }

            Console.ReadLine();
        }
    }

    public static class Extensions
    {
        public static string Delimited(this List<Hobby> sender, string separator = "\t") 
            => string.Join(separator, sender.Select(hobby => hobby.DisplayName));
    }
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Hobby> Hobbies { get; set; }
        public override string ToString() 
            => $"{FirstName} {LastName}";
    }

    public class Hobby
    {
        public int ID { get; set; }
        public string DisplayName { get; set; }
        public override string ToString() 
            => $"{DisplayName}";
    }

    public class Mocking
    {
        public static List<Hobby> HobbyList => new()
        {
            new () {ID = 1, DisplayName = "Gaming"},
            new () {ID = 2, DisplayName = "Music / Playing an instrument"},
            new () {ID = 3, DisplayName = "Sports"},
            new () {ID = 4, DisplayName = "Reading"},
            new () {ID = 5, DisplayName = "Fitness"},
            new () {ID = 6, DisplayName = "Crafting"},
            new () {ID = 7, DisplayName = "Blogging"},
            new () {ID = 8, DisplayName = "Cooking"},
            new () {ID = 9, DisplayName = "Dancing"},
            new () {ID = 10, DisplayName = "Camping"},
            new () {ID = 11, DisplayName = "Pottery"},
            new () {ID = 12, DisplayName = "Racing"}
        };

        public static List<Person> People => new()
        {
            new()
            {
                Id = 1, 
                FirstName = "Karen", 
                LastName = "Payne",
                Hobbies = new List<Hobby>()
                {
                    HobbyList[4],
                    HobbyList[7],
                    HobbyList[1],
                    HobbyList[9]
                }
            },
            new()
            {
                Id = 2, 
                FirstName = "Lisa", 
                LastName = "Smith", 
                Hobbies = new List<Hobby>()
                {
                    HobbyList[3],
                    HobbyList[9], 
                    HobbyList[5]
                }
            },
            new()
            {
                Id = 3,
                FirstName = "Bill",
                LastName = "Rickman",
                Hobbies = new List<Hobby>()
                {
                    HobbyList[1],
                    HobbyList[2],
                    HobbyList[5]
                }
            },
            new()
            {
                Id = 4,
                FirstName = "Vince",
                LastName = "Bushheit",
                Hobbies = new List<Hobby>()
                {
                    HobbyList[10],
                    HobbyList[2],
                    HobbyList[1]
                }
            },
            new()
            {
                Id = 5,
                FirstName = "Bick",
                LastName = "VU",
                Hobbies = new List<Hobby>()
                {
                    HobbyList[5],
                    HobbyList[6],
                    HobbyList[8]
                }
            }

        };
    }
}
