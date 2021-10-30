using System;

namespace Entity.IModels
{
    public interface IEntity
    {
        int Id { get; set; }
        string LastModifiedBy { get; set; }

        DateTime DateModified { get; set; }

        string CreatedBy { get; set; }

        DateTime DateCreated { get; set; }

        bool IsDeleted { get; set; }

        string DeletedBy { get; set; }

        DateTime DeletedDate { get; set; }
    }
}
