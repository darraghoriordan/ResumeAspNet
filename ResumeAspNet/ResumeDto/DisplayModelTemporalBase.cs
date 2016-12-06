using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fuzzyminds.ResumeAspNet.ResumeDto
{
    public class DisplayModelTemporalBase
    {
        public DateTime StartDate { get; set; }

        [NotMapped]
        public string StartDateDisplay
        {
            get { return StartDate.ToString("yyyy MMMM"); }
        }

        [NotMapped]
        public string EndDateDisplay
        {
            get
            {
                if (EndDate == null)
                {
                    return "Present";
                }

                return EndDate.Value.ToString("yyyy MMMM");
            }
        }

        public DateTime? EndDate { get; set; }
    }
}