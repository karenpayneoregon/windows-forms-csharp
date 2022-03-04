using System;

namespace DeserializeAvoidNullConsoleApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Country { get; set; }
        public DateTime StartDate { get; set; }
        public override string ToString() => $"{FirstName} {LastName}";
    }
}