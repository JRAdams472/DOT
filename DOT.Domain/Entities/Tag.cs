using System;
using DOT.Domain.Common;

namespace DOT.Domain.Entities
{
    internal class Tag : AuditalbeEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
