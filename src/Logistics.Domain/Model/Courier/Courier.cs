namespace Logistics.Domain.Model.Courier
{
    public class Courier : GuidEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
