using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOT.Domain.Common;

namespace DOT.Domain.Entities
{
    public class Tag : AuditableEntity
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        
        // Navigation properties
        public virtual ICollection<RequirementTag> RequirementTags { get; set; }
    }
}
