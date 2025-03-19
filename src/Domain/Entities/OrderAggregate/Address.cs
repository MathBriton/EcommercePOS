namespace Core.Entitiess.OrderAggregate
{
    public class Address
    {
        public Address () {}

        public Address(string firstName, string lastName, string street, string city, string state, string zipCode )
        {
            FirstName = firstName;
            lastName = lastName;
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        public string FirstName { get; set; }
        public string LasstName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}