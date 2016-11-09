using System;
using System.Collections.Generic;

namespace Fuzzyminds.ResumeAspNet.ResumeDto
{
    public class ResumeProfile
    {
        public ResumeProfile()
        {
            Awards = new List<string>();
            Recommendations = new List<RecommendationRecord>();
            PositionRecords = new List<PositionRecord>();
            CourseRecords = new List<CourseRecord>();
            EducationRecords = new List<EducationRecord>();
            Skills = new List<string>();
        }

        public DateTime LastModifiedTimestamp { get; set; }
        public string Interests { get; set; }
        public List<string> Skills { get; set; }
        public List<EducationRecord> EducationRecords { get;set;}
        public List<CourseRecord> CourseRecords { get; set; }
        public List<PositionRecord> PositionRecords { get; set; }
        public List<RecommendationRecord> Recommendations { get; set; }
        public List<string> Awards { get; set; }
    }
}