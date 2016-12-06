using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fuzzyminds.ResumeAspNet.ResumeDto
{
    public class PositionRecord : DisplayModelTemporalBase
    {
        public PositionRecord()
        { }

        public int Id { get; set; }
        public string Title { get; set; }
        public CompanyRecord Company { get; set; }
        public string Summary { get; set; }

        public bool IsCurrent { get; set; }

        public int ResumeRecordId { get; set; }
        public virtual ResumeRecord ResumeRecord { get; set; }
    }
}