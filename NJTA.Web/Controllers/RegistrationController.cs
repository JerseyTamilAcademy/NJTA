using System.Web.Mvc;

namespace NJTA.Web.Controllers
{
    public class RegistrationController : Controller
    {
        public ActionResult Index()
        {
            return View("index_2022-23");
        }

        public ActionResult v2021()
        {
            return View("index_2021-22");
        }

        public ActionResult v2020()
        {
            return View("index_2020");
        }
    }
}