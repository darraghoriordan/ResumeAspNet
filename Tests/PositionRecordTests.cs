using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Fuzzyminds.ResumeAspNet.ResumeDto;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class PositionRecordTests
    {
        [TestCase(-1, -1, -1, "Present")]
        [TestCase(2016, 1, 1, "2016 January")]
        public void display_date_is_correct(int year, int month, int day, string expectedResult)
        {

            DateTime? dt;

            if (year <= 1)
            {
                dt = null;
            }
            else
            {
                dt = new DateTime(year, month, day);
            }
            var classUnderTest = new PositionRecord();
            classUnderTest.EndDate = dt;

            classUnderTest.EndDateDisplay.Should().BeEquivalentTo(expectedResult);
        }
    }
}
