using System;
using System.Collections.Generic;
using System.Linq;
using Logistics.Domain.Model.Order;
using Logistics.Domain.Repositories;

namespace Logistics.Application
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IList<Order> GetOrdersWithStatus(StatusType status)
        {
            return _orderRepository.GetAll()
                .Where(x => x.Status == status)
                .ToList();
        }

        public Order Insert(Order obj)
        {
            return _orderRepository.Insert(obj);
        }

        public bool Delete(Guid id)
        {
            return _orderRepository.Delete(id);
        }

        public Order GetById(Guid id)
        {
            return _orderRepository.GetById(id);
        }

        public IList<Order> GetAll()
        {
            return _orderRepository.GetAll().ToList();
        }
    }
}
