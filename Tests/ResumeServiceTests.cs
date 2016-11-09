using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;
using Fuzzyminds.ResumeAspNet.Services;

namespace Tests
{
    [TestFixture]
    public class ResumeServiceTests
    {
        [Test]
        public void can_get_a_resume()
        {
            var resumeService = new ResumeService();
            var result = resumeService.GetResume();

            result.Should().NotBeNull();
            
        }
    }
}
