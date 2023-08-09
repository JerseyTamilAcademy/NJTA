using System.Web.Mvc;

namespace NJTA.Web.Controllers
{
    public class RegistrationController : Controller
    {
        public ActionResult Index()
        {
            return View("index_2023-24");
        }

        public ActionResult v23()
        {
            return View("index_2022-23");
        }
    }
}