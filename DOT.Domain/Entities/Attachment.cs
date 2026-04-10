using System;
using DOT.Domain.Common;

namespace DOT.Domain.Entities
{
    internal class Attachment : AuditalbeEntity
    {
        public int Id { get; set; }
        public int RequirementId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int? FileSize { get; set; }
        public string ContentType { get; set; }
        public DateTime UploadedDate { get; set; }
        public int? UploadedBy { get; set; }
    }
}
