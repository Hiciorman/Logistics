using System;
using System.Collections.Generic;
using Logistics.Domain;

namespace Logistics.Application
{
    public interface IOrderService
    {
        IList<Order> GetAllOrders();
        IList<Order> GetOrdersWithStatus(StatusType status);

        void CreateNewOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Guid order);
    }
}