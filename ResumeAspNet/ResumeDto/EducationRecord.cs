using System;

namespace Fuzzyminds.ResumeAspNet.ResumeDto
{
    public class EducationRecord : DisplayModelTemporalBase
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string FieldOfStudy { get; set; }
        public string Degree { get; set; }
        public string Notes { get; set; }

        public int ResumeRecordId { get; set; }
        public virtual ResumeRecord ResumeRecord { get; set; }
    }
}