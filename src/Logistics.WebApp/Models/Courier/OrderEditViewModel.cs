using Logistics.Domain.Model.Order;

namespace Logistics.WebApp.Models.Courier
{
    public class OrderEditViewModel
    {
        public Order Order { get; set; }
        public StatusType? StatusTypes { get; set; }
    }
}