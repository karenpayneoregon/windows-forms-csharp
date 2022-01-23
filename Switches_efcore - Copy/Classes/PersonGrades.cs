using Switches.Models;

namespace Switches.Classes
{
    public class PersonGrades : PersonEntity
    {
        public decimal? Grade { get; set; }
        public string GradeLetter { get; set; }

        public void Deconstruct(out string firstName, out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }
        public void Deconstruct(out int id, out string firstName, out string lastName)
        {
            id = PersonID;
            firstName = FirstName;
            lastName = LastName;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
