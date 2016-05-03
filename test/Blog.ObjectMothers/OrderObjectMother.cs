using Logistics.Domain.Model.Client;
using Logistics.Domain.Model.Order;

namespace Blog.ObjectMothers
{
    public class OrderObjectMother
    {
        public static Order CreateOrder()
        {
            var o = new Order
            {
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
