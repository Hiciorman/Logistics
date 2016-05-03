using System.Collections.Generic;
using Logistics.Common;
using Logistics.Domain.Model.Order;

namespace Logistics.Application
{
    public interface IOrderService : IGenericService<Order>
    {
        IList<Order> GetOrdersWithStatus(StatusType status);
    }
}