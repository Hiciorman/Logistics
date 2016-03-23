namespace Logistics.Domain.Model.Client
{
    public class Address //value object
    {
        public Address(string street, string city, string region, string country, string postalCode)
        {
            Street = street;
            City = city;
            Region = region;
            Country = country;
            PostalCode = postalCode;
        }

        public string Street { get; private set; }
        public string City { get; private set; }
        public string Region { get; private set; }
        public string Country { get; private set; }
        public string PostalCode { get; private set; }
    }
}
