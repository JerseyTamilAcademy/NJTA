using System.Web.Mvc;

namespace NJTA.Web.Controllers
{
    public class RegistrationController : Controller
    {
        public ActionResult Index()
        {
            return View("Index_2026-27");
        }

        public ActionResult v25()
        {
            return View("Index_2024-25");
        }
    }
}