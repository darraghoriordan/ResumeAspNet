using System;

namespace Fuzzyminds.ResumeAspNet.ResumeDto
{
    public class CourseRecord: DisplayModelTemporalBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }

        public int ResumeRecordId { get; set; }
        public virtual ResumeRecord ResumeRecord { get; set; }
    }
}