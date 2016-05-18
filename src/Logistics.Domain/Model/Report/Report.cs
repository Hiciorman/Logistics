using System;
using System.ComponentModel.DataAnnotations.Schema;
using Logistics.Common;

namespace Logistics.Domain.Model.Report
{
    [Table("Reports")]
    public class Report : Entity
    {
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; } 
    }
}
