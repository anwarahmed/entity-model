using System;
namespace DoubleA.EntityModel.Entities
{
    public abstract class KeyedEntity : IKeyedEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
