using System.Web.Mvc;

namespace NJTA.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Resources()
        {
            ViewBag.Title = "Resources";
            return View("ComingSoon");
        }

        public ActionResult Team()
        {
            return View();
        }
        
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult ContactUs(string id)
        {
            if (string.IsNullOrEmpty(id))
                id = "edison";
            var actionName = RouteData.Values["action"].ToString();
            var viewName = string.Concat(actionName, ".", id);
            return View(viewName);
        }

        //Footer Link
        public ActionResult News()
        {
            ViewBag.Title = "News";
            return View("ComingSoon");
        }
        public ActionResult Events()
        {
            ViewBag.Title = "Events";
            return View("ComingSoon");
        }
        public ActionResult Photos()
        {
            ViewBag.Title = "Photo Galleries";
            return View("ComingSoon");
        }
        public ActionResult Videos()
        {
            return View();
        }

        public ActionResult VolunteersSignUp()
        {
            ViewBag.Title = "Volunteers SignUp";
            return View("ComingSoon");
        }

    }
}