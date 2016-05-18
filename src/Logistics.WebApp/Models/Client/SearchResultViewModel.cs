using System;
using System.Collections.Generic;
using Logistics.Domain.Model.Log;
using Logistics.Domain.Model.Order;

namespace Logistics.WebApp.Models.Client
{
    public class SearchResultViewModel
    {
        public Guid Number { get; set; }

        public List<Log> Logs { get; set; }
    }
}