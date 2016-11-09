using System;

namespace Fuzzyminds.ResumeAspNet.ResumeDto
{
    public class PositionRecord
    {
        public string Title { get; set; }
        public CompanyRecord Company { get; set; }
        public string Summary { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCurrent { get; set; }
    }
}