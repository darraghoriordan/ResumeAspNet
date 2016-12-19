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
            ViewBag.Title = "Home";
            return View();
        }

        public ActionResult ExternalRedirect(string name)
        {
            switch (name)
            {
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

        public ActionResult Portfolio()
        {
            ViewBag.Title = "Portfolio";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Title = "About";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Title = "Contact";
            return View();
        }
        public ActionResult Resume()
        {
            ViewBag.Title = "Resume";
            return View(_resumeService.GetResume());
        }

        public ActionResult WriteToFile()
        {
            var sdb = new SqlDatabaseResumeService(new ApplicationDbContext());
            (_resumeService as JsonDocumentResumeService).WriteResume(sdb.GetResume());

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}