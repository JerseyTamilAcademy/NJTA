using System.Web.Mvc;

namespace NJTA.Web.Controllers
{
    public class ResourcesController : Controller
    {
        public ActionResult Guidelines()
        {
            return View();
        }
        public ActionResult ClassInfo()
        {
            ViewBag.Title = "Class Info";
            return View("ComingSoon");
        }
    }
}