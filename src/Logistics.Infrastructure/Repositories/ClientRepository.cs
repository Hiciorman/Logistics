using Logistics.Common;
using Logistics.Domain;
using Logistics.Domain.Model.Client;
using Logistics.Domain.Repositories;

namespace Logistics.Infrastructure.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(AppContext context) : base(context)
        {
        }
    }
}
