using System.Collections.Generic;

namespace Fuzzyminds.ResumeAspNet.ResumeDto
{
    public class CompanyRecord
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual ICollection<PositionRecord> PositionRecords { get; set; }
    }
}