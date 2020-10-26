using System;
namespace DoubleA.EntityModel.Entities
{
    public abstract class KeyedEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
