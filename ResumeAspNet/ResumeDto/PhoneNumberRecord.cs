using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fuzzyminds.ResumeAspNet.ResumeDto
{
    public class PhoneNumberRecord
    {
        [Key, ForeignKey("ResumeRecord")]
        public int Id { get; set; }
        public PhoneNumberType Type { get; set; }
        public int Number { get; set; }

        public virtual ResumeRecord ResumeRecord { get; set; }
    }
}