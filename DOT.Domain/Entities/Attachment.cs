using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOT.Domain.Common;

namespace DOT.Domain.Entities
{
    public class RequirementAttachment : AuditableEntity
    {
        public int Id { get; set; }
        
        public int RequirementId { get; set; }
        public virtual Requirement Requirement { get; set; }
        
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int FileSize { get; set; }
        public string ContentType { get; set; }
        
        public int? UploadedBy { get; set; }
        public virtual User UploadedByUser { get; set; }
        
        public DateTime UploadedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
