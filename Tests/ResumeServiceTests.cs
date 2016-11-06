using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;
namespace Tests
{
    [TestFixture]
    public class ResumeServiceTests
    {
        [Test]
        public void can_get_a_resume()
        {
            var resumeService = new ResumeAspNet.Services.ResumeService();
            var result = resumeService.GetResume();

            result.Should().NotBeNull();
            result.ResumeContents.Should().NotBeEmpty();
        }
    }
}
