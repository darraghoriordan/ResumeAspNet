using System.Web.Mvc;

namespace ResumeAspNet.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var service = new ResumeAspNet.Services.ResumeService();

            ViewBag.Title = "Darragh's Resume";
            return View(service.GetResume());
        }
    }
}