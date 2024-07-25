using System.Web.Mvc;

namespace NJTA.Web.Controllers
{
    public class RegistrationController : Controller
    {
        public ActionResult Index()
        {
            return View("index_2024-25");
        }

        public ActionResult v24()
        {
            return View("index_2023-24");
        }
    }
}