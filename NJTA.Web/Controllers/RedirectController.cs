using System;
using System.Web.Mvc;

namespace NJTA.Web.Controllers
{
    public class RedirectController : Controller
    {
        private const string DEFAULT_URL = "/";
        public ActionResult Index(string path)
        {
            string redirectURL = string.Empty;
            if (!string.IsNullOrEmpty(path))
                redirectURL = path;
            else
                redirectURL = DEFAULT_URL;
            return RedirectPermanent(redirectURL);
        }
    }
}