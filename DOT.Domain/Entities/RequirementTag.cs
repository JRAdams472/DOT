using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT.Domain.Entities
{
    public class TagRequirement
    {
        public int RequirementId { get; set; }
        public virtual Requirement Requirement { get; set; }
        
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }
        
        public DateTime CreatedDate { get; set; }
    }
}
