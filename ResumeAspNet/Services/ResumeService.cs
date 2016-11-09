using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResumeAspNet.Services
{
    public class ResumeService : IResumeService
    {
        public ResumeAspNet.Models.ResumeModel GetResume()
        {
            return new Models.ResumeModel()
            {
                ResumeContents = "Darragh's resume"
            };
        }
    }
}