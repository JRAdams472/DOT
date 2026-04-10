using System;

namespace DOT.Domain.Entities
{
    internal class Requirement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PriorityLevel { get; set; }
        public string PriorityLabel { get; set; }
        public string Status { get; set; }
        public int? CategoryId { get; set; }
        public string Category { get; set; }
        public int? AssignedToId { get; set; }
        public string AssignedTo { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? EstimationHours { get; set; }
        public decimal? ActualHours { get; set; }
        public int? Version { get; set; }
        public bool IsDeleted { get; set; }
    }
}
