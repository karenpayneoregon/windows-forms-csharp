namespace CustomersDemo
{
    public class Customer
    {
        public int CustomerIdentifier { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public int CountryIdentifier { get; set; }

        public override string ToString() => $"{FirstName} {LastName}";
    }
}