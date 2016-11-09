using System;
using System.Collections.Generic;

namespace Fuzzyminds.ResumeAspNet.ResumeDto
{
    public class ResumeProfile
    {
        public DateTime LastModifiedTimestamp { get; set; }
        public string Interests { get; set; }
        public List<string> Skills { get; set; }
        public List<EducationRecord> EducationRecords { get;set;}
        public List<CourseRecord> CourseRecords { get; set; }
        public List<PositionRecord> PositionRecords { get; set; }
        public List<string> Awards { get; set; }

    }
    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
    public class PositionRecord
    {
        public string Title { get; set; }
        public Company Company { get; set; }
        public string Summary { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCurrent { get; set; }
    }
    public class EducationRecord
    {
        public string SchoolName { get; set; }
        public string FieldOfStudy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Degree { get; set; }
        public string Notes { get; set; }
    }
    public class CourseRecord
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Notes { get; set; }
    }
   
}