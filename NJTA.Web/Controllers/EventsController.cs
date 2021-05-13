using System.Web.Mvc;

namespace NJTA.Web.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            return View("AnnualDay");
        }

        public ActionResult Contest()
        {
            return View();
        }

        public ActionResult AnnualDay()
        {
            return View();
        }
    }
}