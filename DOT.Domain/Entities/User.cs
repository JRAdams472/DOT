using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOT.Domain.Common;

namespace DOT.Domain.Entities
{
    public class User : AuditableEntity
    {
        public int Id { get; set; }
        
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}".Trim();
        
        public bool IsActive { get; set; } = true;
        
        // Navigation properties
        public virtual ICollection<Requirement> Requirements { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
