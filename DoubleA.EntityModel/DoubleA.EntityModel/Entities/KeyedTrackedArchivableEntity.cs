using System;

namespace DoubleA.EntityModel.Entities
{
    public abstract class KeyedTrackedArchivableEntity : IKeyedEntity, ITrackedEntity, IArchivableEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime Updated { get; set; } = DateTime.UtcNow;
        public bool IsArchived { get; set; }
    }
}
