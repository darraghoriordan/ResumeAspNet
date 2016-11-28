using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fuzzyminds.ResumeAspNet.ResumeDto
{
    public class InterestRecord
    {
        public InterestRecord(string name)
        {
            Name = name;
        }

        public InterestRecord()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public int ResumeRecordId { get; set; }
        public virtual ResumeRecord ResumeRecord { get; set; }
    }
}