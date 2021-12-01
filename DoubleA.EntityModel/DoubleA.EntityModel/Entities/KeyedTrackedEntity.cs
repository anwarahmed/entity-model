using System;
namespace DoubleA.EntityModel.Entities
{
    public abstract class KeyedTrackedEntity : IKeyedEntity, ITrackedEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime Updated { get; set; } = DateTime.UtcNow;
    }
}
