using System.Collections.Generic;

namespace Logistics.WebApp.Models.Admin
{
    public class CouriersViewModel
    {
        public CouriersViewModel()
        {
            Couriers= new List<Domain.Model.Courier.Courier>();
        }

        public IList<Domain.Model.Courier.Courier> Couriers { get; set; } 
    }
}