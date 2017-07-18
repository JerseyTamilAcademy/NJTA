using System.Web.Mvc;

namespace NJTA.Web.Util
{
    public class LocalizedRazorViewEngine : RazorViewEngine
    {
        public const bool fallback = true ;

        public override ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            string langExtn = GetLangExtn(controllerContext);

            string localizedPartialViewName = partialViewName;
            if (!string.IsNullOrEmpty(partialViewName))
                localizedPartialViewName += langExtn;

            var result = base.FindPartialView(controllerContext, localizedPartialViewName, useCache);

            if (fallback && result.View == null)
                result = base.FindPartialView(controllerContext, partialViewName, useCache);

            return result;
        }

        public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            string langExtn = GetLangExtn(controllerContext);

            string localizedViewName = viewName;
            if (!string.IsNullOrEmpty(viewName))
                localizedViewName += langExtn;

            string localizedMasterName = masterName;
            if (!string.IsNullOrEmpty(masterName))
                localizedMasterName += langExtn;

            var result = base.FindView(controllerContext, localizedViewName, localizedMasterName, useCache);

            if (fallback && result.View == null)
            {
                result = base.FindView(controllerContext, viewName, masterName, useCache);
            }

            return result;
        }

        private string GetLangExtn(ControllerContext controllerContext)
        {
            string lang = controllerContext.RouteData.Values["lang"].ToString();
            string langExtn = "";
            if (lang == "ta")
                langExtn = ".ta";
            return langExtn;
        }
    }
}


