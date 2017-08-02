using System.Collections;
using System.Web.Mvc;
using System.Linq;

namespace NJTA.Web.Util
{
    public class LocalizedRazorViewEngine : RazorViewEngine
    {
        public override ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            string langExtn = GetLangExtn(controllerContext);
            if (!string.IsNullOrEmpty(langExtn))
            {
                string localizedPartialViewName = string.Concat(partialViewName, langExtn);
                ViewEngineResult result = base.FindPartialView(controllerContext, localizedPartialViewName, useCache);
                bool viewNotExist = result.View == null && result.SearchedLocations.Any();
                if (!viewNotExist)
                    return result;
            }
            return base.FindPartialView(controllerContext, partialViewName, useCache);
        }

        public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            string langExtn = GetLangExtn(controllerContext);
            if (!string.IsNullOrEmpty(langExtn))
            {
                string localizedViewName = string.Concat(viewName, langExtn);
                string localizedMasterName = string.IsNullOrEmpty(masterName) ? masterName : string.Concat(masterName, langExtn);
                ViewEngineResult result = base.FindView(controllerContext, localizedViewName, localizedMasterName, useCache);
                bool viewNotExist = result.View == null && result.SearchedLocations.Any();
                if (!viewNotExist)
                    return result;
            }
            return base.FindView(controllerContext, viewName, masterName, useCache);
        }

        private string GetLangExtn(ControllerContext controllerContext)
        {
            string lang = (controllerContext.RouteData.Values["lang"] as string) ?? string.Empty;
            string langExtn = "";
            if (lang == "ta")
                langExtn = ".ta";
            return langExtn;
        }
    }
}


