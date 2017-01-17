using System.Net;
using System.Web.Http.Results;
using System.Web.Mvc;
using Fuzzyminds.ResumeAspNet.Models;
using Fuzzyminds.ResumeAspNet.Services;

namespace Fuzzyminds.ResumeAspNet.Controllers
{
    public class HomeController : Controller
    {
        readonly IResumeService _resumeService;

        public HomeController(IResumeService resumeService)
        {
            _resumeService = resumeService;
        }

        public ActionResult Index()
        {
            return ExternalRedirect("darraghoriordan");
        }

        public ActionResult ExternalRedirect(string name)
        {
            switch (name)
            {
                case "darraghoriordan":
                    return Redirect("https://www.darraghoriordan.com/");
                case "bitbucket":
                    return Redirect("https://bitbucket.org/darragh/");
                case "github":
                     return Redirect("http://github.com/darraghoriordan");
                case "blog":
                    return Redirect("https://darraghoriordan.wordpress.com/");
                case "linkedin":
                    return Redirect("https://nz.linkedin.com/in/darraghoriordan");

                default:
                    return new HttpNotFoundResult();
            }
        }
    }
}