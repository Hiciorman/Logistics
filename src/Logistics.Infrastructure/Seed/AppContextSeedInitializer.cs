using System;
using System.Data.Entity;
using System.Linq;
using Logistics.Domain.Model.Client;
using Logistics.Domain.Model.Courier;
using Logistics.Domain.Model.Log;
using Logistics.Domain.Model.Order;
using Logistics.Domain.Model.Report;

namespace Logistics.Infrastructure.Seed
{
    public class AppContextSeedInitializer : DropCreateDatabaseAlways<AppContext>
    {
        protected override void Seed(AppContext context)
        {
            #region Clients
            context.Clients.Add(new Client
            {
                FirstName = "John",
                LastName = "Rambo",
                Email = "john.rambo@gmail.com",
                PhoneNumber = "555-555-555",
                Address = new Address("Grabiszyńska",
                "Wrocław", "Dolnośląskie",
                "Polska", "53-514")
            });

            context.Clients.Add(new Client
            {
                FirstName = "Tester",
                LastName = "Testowany",
                Email = "tester@gmail.com",
                PhoneNumber = "777-777-777",
                Address = new Address("Jana Pawła II",
                "Lublin", "Lubelskie",
                "Polska", "20-123")
            });
            context.SaveChanges();
            #endregion

            #region Orders
            context.Orders.Add(new Order
            {
                Package = new Package
                {
                    Height = 10,
                    Width = 10,
                    Weight = 10,
                    IsFragile = true
                },
                Value = 1000,
                Payment = PaymentType.Card,
                Status = StatusType.Packaging,
                Recipent = context.Clients.Single(x => x.FirstName == "Tester"),
                Sender = context.Clients.Single(x => x.FirstName == "John")
            });

            context.Orders.Add(new Order
            {
                Package = new Package
                {
                    Height = 5,
                    Width = 20,
                    Weight = 10,
                    IsFragile = true
                },
                Value = 50,
                Payment = PaymentType.Card,
                Status = StatusType.Dispatched,
                Recipent = context.Clients.Single(x => x.FirstName == "John"),
                Sender = context.Clients.Single(x => x.FirstName == "Tester")
            });
            context.SaveChanges();
            #endregion

            #region Logs
            context.Logs.Add(new Log
            {
                Action = LogType.Packaging,
                DateTime = DateTime.Now.AddDays(-2),
                Location = "Wrocław",
                OrderId = context.Orders.Single(x=> x.Status == StatusType.Dispatched).Id
            });

            context.Logs.Add(new Log
            {
                Action = LogType.Marking,
                DateTime = DateTime.Now.AddDays(-1),
                Location = "Wrocław",
                OrderId = context.Orders.Single(x => x.Status == StatusType.Dispatched).Id
            });

            context.Logs.Add(new Log
            {
                Action = LogType.Packaging,
                DateTime = DateTime.Now.AddDays(-1),
                Location = "Amsterdam",
                OrderId = context.Orders.Single(x => x.Status == StatusType.Packaging).Id
            });
            #endregion

            #region Couriers
            context.Couriers.Add(new Courier
            {
                FirstName = "Louis",
                LastName = "Branger",
                PhoneNumber = "444-555-666"
            });
            context.SaveChanges();
            #endregion

            #region Reports
            context.Reports.Add(new Report
            {
                StartDateTime = DateTime.Now.AddDays(-7),
                EndDateTime = DateTime.Now
            });
            context.SaveChanges();
            #endregion
        }
    }
}