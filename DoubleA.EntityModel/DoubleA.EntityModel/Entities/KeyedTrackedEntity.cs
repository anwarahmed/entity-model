using System;
namespace DoubleA.EntityModel.Entities
{
    public abstract class KeyedTrackedEntity : IKeyedEntity, ITrackedEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;
    }
}
