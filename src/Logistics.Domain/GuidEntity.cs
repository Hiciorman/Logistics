using System;

namespace Logistics.Domain
{
    public abstract class GuidEntity : Entity<Guid>
    {
        protected GuidEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}