namespace Logistics.Domain.Model.Order
{
    public class Order : GuidEntity
    {
        public Client.Client Sender { get; set; }
        public Client.Client Recipent { get; set; }
        public Package Package { get; set; }
        public float Value { get; set; }
        public StatusType Status { get; set; }
        public PaymentType Payment { get; set; }
    }
}
