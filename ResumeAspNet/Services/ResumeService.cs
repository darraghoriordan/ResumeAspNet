using System;
using System.EnterpriseServices;
using Fuzzyminds.ResumeAspNet.ResumeDto;

namespace Fuzzyminds.ResumeAspNet.Services
{
    public class ResumeService : IResumeService
    {
        public ResumeProfile GetResume()
        {
            var co = new CompanyRecord() {Address = "66 Sale St", City = "Auckland", Country = "New Zealand", Name = "Trade Me Ltd"};

            ResumeProfile rp = new ResumeProfile();
            rp.PositionRecords.Add(new PositionRecord()
            {
                Company = co,
                StartDate = new DateTime(2014, 10, 20),
                EndDate = new DateTime(2015, 10, 20),
                IsCurrent = false,
                Summary = "Smashing things at tm",
                Title = "Developer"
            });
            rp.PositionRecords.Add(new PositionRecord()
            {
                Company = co,
                StartDate = new DateTime(2015, 10, 20),
                EndDate = new DateTime(1900, 1, 1),
                IsCurrent = true,
                Summary = "Smashing things at tm",
                Title = "Development Chapter Lead"
            });
            return rp;
        }
    }
}