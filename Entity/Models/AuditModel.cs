using Entity.IModels;
using System;

namespace Entity.Models
{
    public class AuditModel : IEntity
    {
        public int Id { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime DateModified { get; set; }

        public string CreatedBy { get; set; }

        public DateTime DateCreated { get; set; }

        public bool IsDeleted { get; set; }

        public string DeletedBy { get; set; }

        public DateTime DeletedDate { get; set; }
    }
}
