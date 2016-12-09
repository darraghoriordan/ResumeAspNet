using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using NUnit.Framework;
using FluentAssertions;
using Fuzzyminds.ResumeAspNet.Models;
using Fuzzyminds.ResumeAspNet.ResumeDto;
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
            var testName = "AAA";
            var data = new List<ResumeRecord>
            {
                new ResumeRecord() { Name =testName , PositionRecords = new List<PositionRecord>()}
            }.AsQueryable();
            var mockSet = new Mock<DbSet<ResumeRecord>>();
            mockSet.Setup(m => m.Include(It.IsAny<String>())).Returns(mockSet.Object);
            mockSet.As<IQueryable<ResumeRecord>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<ResumeRecord>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<ResumeRecord>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<ResumeRecord>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            
            var dbContextMock = new Mock<ApplicationDbContext>();
            dbContextMock.Setup(dbc => dbc.ResumeRecords).Returns(mockSet.Object);
            var resumeService = new ResumeService(dbContextMock.Object);
            var result = resumeService.GetResume();
            result.Should().NotBeNull();
            result.Name.ShouldBeEquivalentTo(testName);
        }
    }
}
