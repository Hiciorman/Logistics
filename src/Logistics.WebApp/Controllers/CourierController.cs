using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Logistics.Application;
using Logistics.WebApp.Models.Courier;

namespace Logistics.WebApp.Controllers
{
    public class CourierController : Controller
    {
        private readonly IOrderService _orderService;

        public CourierController(IOrderService orderService)
        {
            _orderService = orderService;
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
                Orders = _orderService.GetAll().ToList(),
            };

            return View(model);
        }

        [HttpGet]
        public ActionResult GetOrders(string fromDateTime, string toDateTime)
        {
            var from = DateTime.Parse(fromDateTime);
            var to = DateTime.Parse(toDateTime);

            var m = new OrdersViewModel
            {
                FromDateTime = from,
                ToDateTime = to,
                Orders = _orderService.GetByDate(from, to).ToList()
            };
            return PartialView("_OrdersPartial", m);
        }

        [HttpPost]
        public ActionResult ChangeStatus(string strSelected)
        {
            return RedirectToAction("Orders");
        }

        //[HttpGet]
        //public ActionResult Report(ReportViewModel model)
        //{

        //}
    }
}