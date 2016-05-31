using System;
using System.Collections.Generic;
using Logistics.Domain.Model.Order;

namespace Logistics.WebApp.Models.Shared
{
    public class OrdersViewModel
    {
        public OrdersViewModel()
        {
            Orders = new List<Order>();
        }

        public DateTime FromDateTime { get; set; } = DateTime.Now;

        public DateTime ToDateTime { get; set; } = DateTime.Now;

        public IList<Order> Orders { get; set; } 
    }
}