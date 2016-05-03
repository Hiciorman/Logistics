using Logistics.Common;
using Logistics.Domain.Model.Order;
using Logistics.Domain.Repositories;

namespace Logistics.Infrastructure.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {

    }
}
