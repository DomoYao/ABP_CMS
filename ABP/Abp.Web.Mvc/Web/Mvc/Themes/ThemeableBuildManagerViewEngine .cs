using System.Web.Compilation;
using System.Web.Mvc;
using III.Web.Framework.Themes;

namespace Abp.Web.Mvc.Themes
{
    public abstract class ThemeableBuildManagerViewEngine : ThemeableVirtualPathProviderViewEngine
    {
        protected override bool FileExists(ControllerContext controllerContext, string virtualPath)
        {
            return BuildManager.GetObjectFactory(virtualPath, false) != null;
        }
    }
}
