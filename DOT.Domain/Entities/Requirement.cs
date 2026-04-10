using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOT.Domain.Common;

namespace DOT.Domain.Entities
{
    public class Requirement : AuditableEntity
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        public string Description { get; set; }
        
        // Priority fields
        public int PriorityLevel { get; set; } // 1 = High, 2 = Medium, 3 = Low
        public string PriorityLabel { get; set; } // "High", "Medium", "Low"
        
        // Status and tracking
        public string Status { get; set; } // "Active", "Completed", "Blocked", "Deferred"
        public DateTime? DueDate { get; set; }
        public int? Version { get; set; }
        
        // Categorization
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string Category { get; set; } // Denormalized for quick access
        
        // Assignment
        public int? AssignedToId { get; set; }
        public virtual User AssignedTo { get; set; }
        public string AssignedTo { get; set; } // Denormalized
        
        // Tracking
        public decimal? EstimationHours { get; set; }
        public decimal? ActualHours { get; set; }
        
        // Audit fields
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        
        // Navigation properties
        public virtual ICollection<RequirementComment> Comments { get; set; }
        public virtual ICollection<RequirementAttachment> Attachments { get; set; }
        public virtual ICollection<RequirementTag> Tags { get; set; }
        
        // Soft delete
        public bool IsDeleted { get; set; } = false;
    }
}
