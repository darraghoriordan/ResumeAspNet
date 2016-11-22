using System;

namespace Fuzzyminds.ResumeAspNet.ResumeDto
{
    public class EducationRecord
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string FieldOfStudy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Degree { get; set; }
        public string Notes { get; set; }

        public int ResumeRecordId { get; set; }
        public virtual ResumeRecord ResumeRecord { get; set; }
    }
}