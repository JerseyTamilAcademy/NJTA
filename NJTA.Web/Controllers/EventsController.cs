using System.Web.Mvc;

namespace NJTA.Web.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            return View("Contest");
        }

        public ActionResult Contest()
        {
            return View();
        }
    }
}