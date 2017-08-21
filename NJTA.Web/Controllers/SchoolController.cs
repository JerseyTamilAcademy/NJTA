using System.Web.Mvc;

namespace NJTA.Web.Controllers
{
    public class SchoolController : Controller
    {
        // GET: School
        public ActionResult Index()
        {
            ViewBag.Title = "Our Schools";
            return View("ComingSoon");
        }

        public ActionResult Edison()
        {
            return View();
        }

        public ActionResult Parsippany()
        {
            ViewBag.Title = "Parsippany";
            return View("ComingSoon");
        }
    }
}