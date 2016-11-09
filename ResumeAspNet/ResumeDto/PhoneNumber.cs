using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fuzzyminds.ResumeAspNet.ResumeDto
{
    public enum PhoneNumberType
    {
        Home=0,
        Mobile=1,
        Work=2
    }

    public class PhoneNumber
    {
        public PhoneNumberType Type { get; set; }
        public int Number { get; set; }
    }
}