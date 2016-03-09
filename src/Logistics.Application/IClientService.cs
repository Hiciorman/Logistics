using System.Collections.Generic;
using Logistics.Domain;

namespace Logistics.Application
{
    public interface IClientService
    {
        IList<Client> GetAllClients();
    }
}
