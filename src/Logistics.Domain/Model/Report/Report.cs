using System;

namespace Logistics.Domain.Model.Report
{
    public class Report //entity
    {
        public Guid Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; } 
    }
}
