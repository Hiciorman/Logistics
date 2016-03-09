using System;
using System.Collections.Generic;
using System.Linq;

namespace Logistics.Domain
{
    public class Client //entity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
    }
}