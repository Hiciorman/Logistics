using System;
using System.ComponentModel.DataAnnotations;

namespace Logistics.Common
{
    public abstract class Entity
    {
        [Key]
        public Guid Id { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
