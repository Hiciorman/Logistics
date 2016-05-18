using Logistics.Common;
using Logistics.Domain;
using Logistics.Domain.Model.Courier;
using Logistics.Domain.Repositories;

namespace Logistics.Infrastructure.Repositories
{
    public class CourierRepository : GenericRepository<Courier>, ICourierRepository
    {
        public CourierRepository(AppContext context) : base(context)
        {
        }
    }
}
