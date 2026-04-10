using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOT.Domain.Common;

namespace DOT.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; } = 0;
        
        public bool IsActive { get; set; } = true;
        
        // Navigation properties
        public virtual ICollection<Requirement> Requirements { get; set; }
    }
}
