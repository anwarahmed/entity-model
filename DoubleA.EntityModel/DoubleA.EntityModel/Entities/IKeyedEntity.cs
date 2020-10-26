using System;
namespace DoubleA.EntityModel.Entities
{
    public interface IKeyedEntity
    {
        Guid Id { get; }
    }
}
