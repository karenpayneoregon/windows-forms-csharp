using System.Collections.Generic;

namespace CustomersDemo
{
public class MockedData
{
    public static List<Customer> Customers() => new List<Customer>()
    {
        new Customer()
        {
            CustomerIdentifier = 1, FirstName = "Jim", LastName = "Adams",
            Street = "120 Hanover Sq.", City = "London", PostalCode = "WA1 1DP", 
            CountryIdentifier = 19
        },
        new Customer()
        {
            CustomerIdentifier = 2, FirstName = "Mary", LastName = "Adams",
            Street = "1 rue Alsace-Lorraine", City = "Toulouse", PostalCode = "31000", 
            CountryIdentifier = 8
        },
        new Customer()
        {
            CustomerIdentifier = 3, FirstName = "Karen", LastName = "White",
            Street = "120 Hanover Sq.", City = "London", PostalCode = "WA1 1DP", 
            CountryIdentifier = 19
        }
    };
}
}