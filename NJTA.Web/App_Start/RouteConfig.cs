using System.Web.Mvc;
using System.Web.Routing;

namespace NJTA.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
        
            routes.MapRoute(
                name: "Lang",
                url: "{lang}/{controller}/{action}/{id}",
                defaults: new { lang = "en", controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { lang = "en|ta" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}