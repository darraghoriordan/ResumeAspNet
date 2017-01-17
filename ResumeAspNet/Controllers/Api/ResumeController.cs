using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Http;
using Fuzzyminds.ResumeAspNet.ResumeDto;
using Fuzzyminds.ResumeAspNet.Services;

namespace Fuzzyminds.ResumeAspNet.Controllers.Api
{
    public class ResumeController : ApiController
    {
        private readonly IResumeService _resumeService;

        public ResumeController(IResumeService resumeService)
        {
            _resumeService = resumeService;
        }

        public async Task<ResumeRecord> Get()
        {
            return await _resumeService.GetResume();
        }
    }
}