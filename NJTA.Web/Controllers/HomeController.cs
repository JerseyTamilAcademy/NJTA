using System;
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

        public ActionResult Calendar()
        {
            return View();
        }

        public ActionResult Contact(string id)
        {
            string[] supportedLocations = new string[] { "Edison", "Parsippany" };
            int pos = Array.FindIndex(supportedLocations, t => t.Equals(id, StringComparison.OrdinalIgnoreCase));
            var location = (pos > -1) ? supportedLocations[pos] : "Edison";

            ViewBag.Location = location;
            var viewName = string.Concat("Contact.", location);
            return View(viewName);
        }

        public ActionResult ContactUs(string id)
        {
            string[] supportedLocations = new string[] { "Edison", "Parsippany" };
            int pos = Array.FindIndex(supportedLocations, t => t.Equals(id, StringComparison.OrdinalIgnoreCase));
            var location = (pos > -1) ? supportedLocations[pos] : "Edison";

            ViewBag.Location = location;
            var viewName = "Contact";
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
            return View("");
        }

    }
}