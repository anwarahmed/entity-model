using System;

namespace DoubleA.EntityModel.Entities
{
    public interface ITrackedEntity
    {
        DateTime CreatedOn { get; set; }

        DateTime UpdatedOn { get; set; }
    }
}
