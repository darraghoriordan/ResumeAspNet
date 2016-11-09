using ResumeAspNet.Services;
using System.Web.Mvc;

namespace ResumeAspNet.Controllers
{
    
    public class HomeController : Controller
    {
        IResumeService _resumeService;

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