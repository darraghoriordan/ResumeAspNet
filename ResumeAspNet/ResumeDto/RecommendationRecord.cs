﻿namespace Fuzzyminds.ResumeAspNet.ResumeDto
{
    public class RecommendationRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }

        public int ResumeRecordId { get; set; }
        public virtual ResumeRecord ResumeRecord { get; set; }
    }
}