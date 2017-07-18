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
            ViewBag.Title = "Our Team";
            return View("ComingSoon");
        }
        
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
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
            ViewBag.Title = "Video Albums";
            return View("ComingSoon");
        }

        public ActionResult VolunteersSignUp()
        {
            ViewBag.Title = "Volunteers SignUp";
            return View("ComingSoon");
        }

    }
}