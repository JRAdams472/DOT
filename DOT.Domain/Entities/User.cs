using System;
using DOT.Domain.Common;

namespace DOT.Domain.Entities
{
    internal class User : AuditalbeEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; }
    }
}
