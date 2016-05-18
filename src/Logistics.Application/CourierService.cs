using System;
using System.Collections.Generic;
using System.Linq;
using Logistics.Domain.Model.Courier;
using Logistics.Domain.Repositories;

namespace Logistics.Application
{
    public class CourierService : ICourierService
    {
        private readonly ICourierRepository _courierRepository;

        public CourierService(ICourierRepository courierRepository)
        {
            _courierRepository = courierRepository;
        }

        public Courier Insert(Courier obj)
        {
            return _courierRepository.Insert(obj);
        }

        public bool Update(Courier obj)
        {
            return _courierRepository.Update(obj);
        }

        public bool Delete(Guid id)
        {
            return _courierRepository.Delete(id);
        }

        public void Save()
        {
            _courierRepository.Save();
        }

        public Courier GetById(Guid id)
        {
            return _courierRepository.GetById(id);
        }

        public IList<Courier> GetAll()
        {
            return _courierRepository.GetAll().ToList();
        }
    }
}