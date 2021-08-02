using System.Web.Mvc;

namespace NJTA.Web.Controllers
{
    public class RegistrationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult v2020()
        {
            return View("index_2020");
        }
    }
}