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
                Console.WriteLine($"{person.Id:D3}{person, 12} - {person.Hobbies.Delimited()}");
                Console.WriteLine();
            }

            Console.WriteLine();

            foreach (var person in Mocking.People)
            {
                Console.WriteLine($"{person.Id:D2}{person,12}");
                foreach (var hobby in person.Hobbies)
                {
                    Console.WriteLine($"\t{hobby.ID,-3}{hobby}");
                }
            }

            Console.ReadLine();
        }
    }

    public static class Extensions
    {
        public static string Delimited(this List<Hobby> sender, string separater = "\t") 
            => string.Join(separater, sender.Select(hobby => hobby.Name));
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
        public string Name { get; set; }
        public override string ToString() 
            => $"{Name}";
    }

    public class Mocking
    {
        public static List<Hobby> HobbyList => new()
        {
            new () {ID = 1, Name = "Gaming"},
            new () {ID = 2, Name = "Music / Playing an instrument"},
            new () {ID = 3, Name = "Sports"},
            new () {ID = 4, Name = "Reading"},
            new () {ID = 5, Name = "Fitness"},
            new () {ID = 6, Name = "Crafting"},
            new () {ID = 8, Name = "Blogging"},
            new () {ID = 9, Name = "Cooking"},
            new () {ID = 10, Name = "Dancing"},
            new () {ID = 11, Name = "Pottery"}
        };

        public static List<Person> People => new List<Person>()
        {
            new Person()
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
            new Person()
            {
                Id = 2, 
                FirstName = "Anne", 
                LastName = "Smith", 
                Hobbies = new List<Hobby>()
                {
                    HobbyList[3],
                    HobbyList[9], 
                    HobbyList[5]
                }
            }
        };
    }
}
