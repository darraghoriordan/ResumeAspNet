using System.Web.Mvc;

namespace ResumeAspNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Darragh's Resume";
            return View();
        }
    }
}