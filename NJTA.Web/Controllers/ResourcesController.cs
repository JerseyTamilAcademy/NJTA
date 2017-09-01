using System.Web.Mvc;

namespace NJTA.Web.Controllers
{
    public class ResourcesController : Controller
    {
        public ActionResult Guidelines()
        {
            ViewBag.Title = "Guidelines";
            return View("ComingSoon");
        }
        public ActionResult ClassInfo()
        {
            ViewBag.Title = "Class Info";
            return View("ComingSoon");
        }
    }
}