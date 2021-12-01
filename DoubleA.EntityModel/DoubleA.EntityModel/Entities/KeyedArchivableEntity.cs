using System;

namespace DoubleA.EntityModel.Entities
{
    public abstract class KeyedArchivableEntity : IKeyedEntity, IArchivableEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool IsArchived { get; set; }
    }
}
