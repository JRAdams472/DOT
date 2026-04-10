using System;

namespace DOT.Domain.Entities
{
    internal class Comment
    {
        public int Id { get; set; }
        public int RequirementId { get; set; }
        public int? UserId { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
