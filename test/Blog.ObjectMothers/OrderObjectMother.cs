using Logistics.Domain.Model.Client;
using Logistics.Domain.Model.Order;
using System;

namespace Blog.ObjectMothers
{
    public class OrderObjectMother
    {
        public static Order CreateOrder()
        {
            var o = new Order
            {
                Number = new Guid(),
                Package = new Package(),
                Sender = new Client(),
                Recipent = new Client(),
                Payment = PaymentType.Card,
                Status = StatusType.Marking,
                Value = 1000
            };

            return o;
        }

        public static Order CreateOrderWithStatus(StatusType statusType)
        {
            var o = new Order
            {
                Number = new Guid(),
                Package = new Package(),
                Sender = new Client(),
                Recipent = new Client(),
                Payment = PaymentType.Card,
                Status = statusType,
                Value = 1000
            };

            return o;
        }
    }
}
