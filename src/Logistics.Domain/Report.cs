using System;
using System.Collections.Generic;

namespace Logistics.Domain
{
    public class Report //entity
    {
        public Guid Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; } 
    }
}
