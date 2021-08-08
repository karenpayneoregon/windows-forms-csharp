using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncSimple.Classes
{
    public class MockedData
    {
        public static List<Customers> MockedInMemoryCustomers()
        {
            var customers = new List<Customers>()
            {
                new () {CustomerIdentifier = 1,CompanyName = "Ana Trujillo Emparedados y helados", ContactId = 2, ContactTypeIdentifier = 7,CountryIdentifier = 12},
                new () {CustomerIdentifier = 2,CompanyName = "Antonio Moreno Taquería", ContactId = 3, ContactTypeIdentifier = 7,CountryIdentifier = 12},
                new () {CustomerIdentifier = 3,CompanyName = "Around the Horn", ContactId = 4, ContactTypeIdentifier = 12, CountryIdentifier = 19},
            };

            return customers;

        }
    }
}
