using System;

namespace DoubleA.EntityModel.Entities
{
    public interface ITrackedEntity
    {
        DateTime Created { get; set; }

        DateTime Updated { get; set; }
    }
}
