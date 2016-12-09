using System;
using System.Collections.Generic;

namespace Fuzzyminds.ResumeAspNet.ResumeDto
{
    public class ResumeRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string Location { get; set; }
        public PhoneNumberRecord PhoneNumber { get; set; }
        public DateTime LastModifiedTimestamp { get; set; }
        public ICollection<InterestRecord> Interests { get; set; }
        public ICollection<SkillRecord> Skills { get; set; }
        public ICollection<EducationRecord> EducationRecords { get;set;}
        public ICollection<CourseRecord> CourseRecords { get; set; }
        public ICollection<PositionRecord> PositionRecords { get; set; }
        public ICollection<RecommendationRecord> Recommendations { get; set; }
        public ICollection<AwardRecord> Awards { get; set; }
    }
}