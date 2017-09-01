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

        public ActionResult Calendar(string id)
        {
            string location = FindLocation(id);
            ViewBag.Location = location;
            var calendarInfo = GetCalendarInfo(location);
            return View(calendarInfo);
        }
        
        public ActionResult Contact(string id)
        {
            string location = FindLocation(id);
            ViewBag.Location = location;
            return View();
        }

        private static string FindLocation(string id)
        {
            string[] supportedLocations = new string[] { "Edison", "Parsippany" };
            int pos = Array.FindIndex(supportedLocations, t => t.Equals(id, StringComparison.OrdinalIgnoreCase));
            var location = (pos > -1) ? supportedLocations[pos] : "Edison";
            return location;
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
            return View();
        }


        private string[] GetCalendarInfo(string location)
        {
            var filePath = @"~/App_Data/Calendar." + location + ".csv";
            var fileServerPath = Server.MapPath(filePath);
            var calendarContent = System.IO.File.ReadAllText(fileServerPath).Split('\n');
            return calendarContent;
        }

    }
}