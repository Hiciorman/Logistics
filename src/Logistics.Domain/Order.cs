using System;

namespace Logistics.Domain
{
    public class Order //entity
    {
        public Guid Number { get; set; }
        public Client Sender { get; set; }
        public Client Recipent { get; set; }
        public Package Package { get; set; }
        public StatusType Status { get; set; }
        public PaymentType Payment { get; set; }
    }
}
