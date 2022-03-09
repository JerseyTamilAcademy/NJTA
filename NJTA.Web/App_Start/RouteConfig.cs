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

            routes.MapRoute("YouTube", "live/{*pathInfo}", new { controller = "Redirect", action = "Index", path="https://www.youtube.com/channel/UCNTAyRT9Z3KhIFY_79l5pCQ/live" });

            routes.MapRoute("Zoom", "zoom/{*pathInfo}", new { controller = "Redirect", action = "Index", path="https://us02web.zoom.us/j/3879823360?pwd=WjNxc09DUGhHRTdPK054R2VvcHBQQT09" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        
        }
    }
}