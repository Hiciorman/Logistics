using System;

namespace Logistics.Domain.Model.Order
{
    public class Package //value object
    {
        public DateTime? DateOfPacking { get; set; }
        public DateTime? DateOfMarking { get; set; }
        public DateTime? DateOfDispatch { get; set; }
        public DateTime? DateOfDelivery { get; set; }
        public float Weight { get; set; }
        public float Heght { get; set; }
        public float Width { get; set; }
        public bool IsFragile { get; set; }
    }
}
