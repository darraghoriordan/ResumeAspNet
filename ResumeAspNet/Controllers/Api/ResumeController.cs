using System.Threading.Tasks;
using System.Web.Http;

namespace Fuzzyminds.ResumeAspNet.Controllers.Api
{
   
    public class ResumeController : ApiController
    {
        // yea yea not at all async yet!
        public async Task<string> Get()
        {
            return "Darragh's resume";
        }
    }
}