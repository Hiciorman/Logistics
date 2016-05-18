using System;
using System.Collections.Generic;
using System.Linq;
using Logistics.Domain.Model.Client;
using Logistics.Domain.Repositories;

namespace Logistics.Application
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public Client Insert(Client obj)
        {
            return _clientRepository.Insert(obj);
        }

        public bool Update(Client obj)
        {
            return _clientRepository.Update(obj);
        }

        public bool Delete(Guid id)
        {
            return _clientRepository.Delete(id);
        }

        public void Save()
        {
            _clientRepository.Save();
        }

        public Client GetById(Guid id)
        {
            return _clientRepository.GetById(id);
        }

        public IList<Client> GetAll()
        {
            return _clientRepository.GetAll().ToList();
        }
    }
}
