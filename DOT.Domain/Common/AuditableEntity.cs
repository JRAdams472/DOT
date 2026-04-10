using System;

namespace DOT.Domain.Common
{
    public abstract class AuditableEntity
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
        
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedDate { get; set; }
    }
}
