using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ResumeAspNet.Controllers.Api
{
    [Authorize]
    public class ResumeController : ApiController
    {
        // GET api/<controller>
        public string Get()
        {
            return "Darragh's resume" ;
        }
    }
}