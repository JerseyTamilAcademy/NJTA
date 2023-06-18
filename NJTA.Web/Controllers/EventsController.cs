using System.Web.Mvc;

namespace NJTA.Web.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            return Graduation();
        }

        public ActionResult Contest()
        {
            return View("Contest2020");
        }

        public ActionResult AnnualDay()
        {
            return View("AnnualDay2023");
        }

        public ActionResult Graduation()
        {
            return View("Graduation2022");
        }
    }
}