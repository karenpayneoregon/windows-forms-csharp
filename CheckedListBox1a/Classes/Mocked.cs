using System.Collections.Generic;

namespace CheckedListBox1a.Classes
{
    public class Mocked
    {
        public static List<Company> Companies => new List<Company>()
        {
            new Company() {Id = 1, Name = "A"},
            new Company() {Id = 2, Name = "B"},
            new Company() {Id = 3, Name = "C"},
            new Company() {Id = 4, Name = "D"},
        };
    }
}