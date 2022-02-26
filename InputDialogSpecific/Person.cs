using System;

namespace InputDialogSpecific
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public override string ToString() => $"{FirstName},{LastName},{BirthDate:d}";
    }
}