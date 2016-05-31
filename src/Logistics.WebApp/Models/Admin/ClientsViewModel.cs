using System.Collections.Generic;

namespace Logistics.WebApp.Models.Admin
{
    public class ClientsViewModel
    {
        public ClientsViewModel()
        {
            Clients = new List<Domain.Model.Client.Client>();
        }

        public IList<Domain.Model.Client.Client> Clients { get; set; }
    }
}