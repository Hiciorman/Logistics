using System;

namespace Logistics.Domain.Model.Order
{
    public class Package
    {
        public DateTime? DateOfPacking { get; set; }
        public DateTime? DateOfMarking { get; set; }
        public DateTime? DateOfDispatch { get; set; }
        public DateTime? DateOfDelivery { get; set; }
        public float Weight { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public bool IsFragile { get; set; }
    }
}
