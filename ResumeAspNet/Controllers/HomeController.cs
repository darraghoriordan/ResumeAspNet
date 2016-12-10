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
            ViewBag.Title = "Darragh's Resume";
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