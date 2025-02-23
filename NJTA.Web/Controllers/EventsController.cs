using System.Web.Mvc;

namespace NJTA.Web.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            //return Graduation();
            return Contest();
        }

        //public ActionResult Contest()
        //{
        //    return View("Contest2020");
        //}
        
        public ActionResult Contest()
	{
            return View("Contest2025");
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