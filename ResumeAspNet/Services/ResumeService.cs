using System;
using System.EnterpriseServices;
using System.Linq;
using Fuzzyminds.ResumeAspNet.Models;
using Fuzzyminds.ResumeAspNet.ResumeDto;
using System.Data.Entity;

namespace Fuzzyminds.ResumeAspNet.Services
{
    public class ResumeService : IResumeService
    {
        private readonly ApplicationDbContext _dbContext;

        public ResumeService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ResumeRecord GetResume()
        {

            ResumeRecord rp = _dbContext.ResumeRecords
                .Include(r=> r.PhoneNumber)
                .Include(r=> r.Interests)
                .Include(r=> r.PositionRecords.Select(p=> p.Company))
                .Include(r=> r.Recommendations)
                .Include(r=> r.Skills)
                .Include(r=> r.Awards)
                .Include(r=> r.CourseRecords)
                .Include(r=> r.EducationRecords)
                .FirstOrDefault();
        
            return rp;
        }
    }
}