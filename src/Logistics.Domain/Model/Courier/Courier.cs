using System;

namespace Logistics.Domain.Model.Courier
{
    public class Courier //entity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
