using System;
using System.Collections.Generic;
using Logistics.Domain.Model.Log;

namespace Logistics.WebApp.Models.Client
{
    public class SearchResultViewModel
    {
        public SearchResultViewModel()
        {
            Logs = new List<Log>();
        }

        public Guid Number { get; set; }

        public List<Log> Logs { get; set; }
    }
}