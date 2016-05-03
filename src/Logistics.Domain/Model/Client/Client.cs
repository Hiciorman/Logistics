namespace Logistics.Domain.Model.Client
{
    public class Client : GuidEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }
}