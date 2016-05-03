using System.ComponentModel.DataAnnotations;

namespace Logistics.Domain
{
    public abstract class Entity<T>
    {
        [Key]
        public T Id { get; set; }
    }
}
