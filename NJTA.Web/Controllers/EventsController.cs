using System.Web.Mvc;

namespace NJTA.Web.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            return AnnualDay();
        }

        public ActionResult Contest()
        {
            return View("Contest2020");
        }

        public ActionResult AnnualDay()
        {
            return View("AnnualDay2023");
        }

        public ActionResult Graduation2021()
        {
            return View("Graduation2021");
        }
    }
}