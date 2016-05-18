using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Logistics.Domain;
using Logistics.Domain.Model.Log;
using Logistics.Domain.Model.Order;
using Logistics.Domain.Repositories;

namespace Logistics.Infrastructure.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly AppContext _context;
        public OrderRepository(AppContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Log> GetLogs(Guid id)
        {
            return _context.Logs.Where(x => x.OrderId == id);
        }

        public IEnumerable<Order> GetByDate(DateTime fromDateTime, DateTime toDateTime)
        {
            var ordersFromLogs = _context.Logs
                .Where(o => o.DateTime >= fromDateTime && o.DateTime <= toDateTime)
                .Select(o => o.OrderId)
                .Distinct();

            return _context.Orders
                .Where(o => ordersFromLogs.Contains(o.Id))
                .Include(o=> o.Sender)
                .Include(o => o.Recipent);
        }

        public override IEnumerable<Order> GetAll()
        {
            return _context.Set<Order>()
                .Include(x => x.Sender)
                .Include(o => o.Recipent);
        }
    }
}