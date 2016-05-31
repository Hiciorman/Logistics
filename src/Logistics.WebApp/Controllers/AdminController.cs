using System;
using System.Web.Mvc;
using Logistics.Application;
using Logistics.Domain.Model.Order;
using Logistics.WebApp.Models.Admin;
using Logistics.WebApp.Models.Courier;
using Logistics.WebApp.Models.Shared;

namespace Logistics.WebApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IClientService _clientService;
        private readonly ICourierService _courierService;

        public AdminController(IOrderService orderService, IClientService clientService, ICourierService courierService)
        {
            _orderService = orderService;
            _clientService = clientService;
            _courierService = courierService;
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {

            return RedirectToAction("Orders");
        }

        [HttpGet]
        public ActionResult Orders()
        {
            var model = new OrdersViewModel
            {
                Orders = _orderService.GetAll()
            };

            return View(model);
        }

        [HttpGet]
        public ActionResult Clients()
        {
            var model = new ClientsViewModel
            {
                Clients = _clientService.GetAll()
            };

            return View(model);
        }

        [HttpGet]
        public ActionResult Couriers()
        {
            var model = new CouriersViewModel
            {
                Couriers = _courierService.GetAll()
            };

            return View(model);
        }

        [HttpGet]
        public ActionResult OrderEdit(Guid orderid)
        {

            var order = _orderService.GetById(orderid);

            return View(order);
        }

        [HttpPost]
        public ActionResult OrderEdit(Order model)
        {
            var order = _orderService.GetById(model.Id);
            order.Value = model.Value;
            order.Package = model.Package;
            order.Status = model.Status;
            order.Payment = model.Payment;

            _orderService.Update(order);

            return RedirectToAction("Orders");
        }


        [HttpGet]
        public ActionResult OrderDelete(string orderId)
        {
            _orderService.Delete(Guid.Parse(orderId));

            return JavaScript("location.reload(true)");
        }
    }
}