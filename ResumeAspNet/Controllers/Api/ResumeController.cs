using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ResumeAspNet.Controllers.Api
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