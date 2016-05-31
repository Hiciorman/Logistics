using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Logistics.Common;

namespace Logistics.Domain.Model.Order
{
    public class Order : Entity
    {
        public Order()
        {
            Logs = new HashSet<Log.Log>();
        }

        public Client.Client Sender { get; set; }

        public Client.Client Recipent { get; set; }

        public virtual Package Package { get; set; }

        public float Value { get; set; }

        public StatusType Status { get; set; }

        public PaymentType Payment { get; set; }

        public virtual ICollection<Log.Log> Logs { get; set; }
    }
}
