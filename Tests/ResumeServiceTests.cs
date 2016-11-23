using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;
using Fuzzyminds.ResumeAspNet.Models;
using Fuzzyminds.ResumeAspNet.Services;
using Moq;

namespace Tests
{
    [TestFixture]
    public class ResumeServiceTests
    {
        [Test]
        public void can_get_a_resume()
        {
            var resumeService = new ResumeService(new Mock<ApplicationDbContext>().Object);
            var result = resumeService.GetResume();

            result.Should().NotBeNull();
            
        }
    }
}
