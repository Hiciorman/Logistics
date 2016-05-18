using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logistics.Domain.Model.Order
{
    public class Package
    {
        [Required]
        [Column("Weight")]
        public float Weight { get; set; }

        [Column("Height")]
        public float Height { get; set; }

        [Column("Width")]
        public float Width { get; set; }

        [Required]
        [Column("IsFragile")]
        public bool IsFragile { get; set; }
    }
}
