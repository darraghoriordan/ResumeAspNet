using System.Web.Mvc;
using System.Web.Routing;

namespace Fuzzyminds.ResumeAspNet
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Linkedin",
                url: "linkedin",
                defaults: new { controller = "Home", action = "ExternalRedirect", name = "linkedin" }
            );
            routes.MapRoute(
                name: "Bitbucket",
                url: "bitbucket",
                defaults: new { controller = "Home", action = "ExternalRedirect", name = "bitbucket" }
            );
            routes.MapRoute(
                name: "Github",
                url: "github",
                defaults: new { controller = "Home", action = "ExternalRedirect", name = "github" }
            );
            routes.MapRoute(
                name: "Blog",
                url: "blog",
                defaults: new { controller = "Home", action = "ExternalRedirect", name = "blog" }
            );
            routes.MapRoute(
                name: "Resume",
                url: "resume",
                defaults: new { controller = "Home", action = "Resume" }
            );
            routes.MapRoute(
                name: "Contact",
                url: "contact",
                defaults: new { controller = "Home", action = "Contact" }
            );
            routes.MapRoute(
                name: "Portfolio",
                url: "portfolio",
                defaults: new { controller = "Home", action = "Portfolio" }
            );
            routes.MapRoute(
               name: "About",
               url: "about",
               defaults: new { controller = "Home", action = "About" }
           );
           routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
