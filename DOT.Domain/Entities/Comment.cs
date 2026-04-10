using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOT.Domain.Common;

namespace DOT.Domain.Entities
{
    public class Comment : AuditableEntity
    {
        public int Id { get; set; }
        
        public int RequirementId { get; set; }
        public virtual Requirement Requirement { get; set; }
        
        public int? UserId { get; set; }
        public virtual User Author { get; set; }
        
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
