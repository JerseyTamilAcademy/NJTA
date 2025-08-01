using System.Web.Mvc;

namespace NJTA.Web.Controllers
{
    public class RegistrationController : Controller
    {
        public ActionResult Index()
        {
            return View("index_2025-26");
        }

        public ActionResult v25()
        {
            return View("index_2024-25");
        }
    }
}