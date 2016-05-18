using System;
using System.Collections.Generic;
using Logistics.Common;
using Logistics.Domain.Model.Log;
using Logistics.Domain.Model.Order;

namespace Logistics.Application
{
    public interface IOrderService : IGenericService<Order>
    {
        IList<Order> GetOrdersWithStatus(StatusType status);
        IList<Log> GetLogs(Guid id);
        IList<Order> GetByDate(DateTime fromDateTime, DateTime toDateTime);
    }
}