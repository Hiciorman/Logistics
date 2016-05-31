using System;
using System.Linq;
using System.Web.Mvc;
using Logistics.Application;
using Logistics.Domain.Model.Order;
using Logistics.WebApp.Models.Client;

namespace Logistics.WebApp.Controllers
{
    public class ClientController : Controller
    {
        private readonly IOrderService _orderService;

        public ClientController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public ActionResult Search()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Search(SearchViewModel model)
        {
            var result = new SearchResultViewModel();

            if (model.OrderId != Guid.Empty)
            {

                var xx = _orderService.GetById(model.OrderId);

                result.Number = xx.Id;
                result.Logs = xx.Logs.ToList();
            }

            return View("SearchResult", result);
        }

        [HttpGet]
        public ActionResult SearchResult(SearchResultViewModel model)
        {
            return View();
        }

    }
}