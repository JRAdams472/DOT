using System;
using DOT.Domain.Common;

namespace DOT.Domain.Entities
{
    internal class Category : AuditalbeEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool IsActive { get; set; }
    }
}
