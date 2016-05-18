using System;
using System.Collections.Generic;
using Logistics.Common;
using Logistics.Domain.Model.Log;
using Logistics.Domain.Model.Order;

namespace Logistics.Domain.Repositories
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        IEnumerable<Log> GetLogs(Guid id);
        IEnumerable<Order> GetByDate(DateTime fromDateTime, DateTime toDateTime);
    }
}
