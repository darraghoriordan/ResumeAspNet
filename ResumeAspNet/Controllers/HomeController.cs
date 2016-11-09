using System.Web.Mvc;
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

            ViewBag.Title = "Darragh's Resume";
            return View(_resumeService.GetResume());
        }
    }
}