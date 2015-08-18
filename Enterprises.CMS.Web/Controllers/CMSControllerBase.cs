using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc.Filters;
using System.Web.Routing;
using Abp.Runtime.Session;
using Abp.Web.Mvc.Controllers;
using Enterprises.CMS.Sessions;
using Enterprises.CMS.Sessions.Dto;
using Microsoft.AspNet.Identity;

namespace Enterprises.CMS.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class CMSControllerBase : AbpController
    {
        public readonly ISessionAppService SessionService;

        protected  CMSControllerBase()
        {
            LocalizationSourceName = CMSConsts.LocalizationSourceName;
        }


        protected override void OnAuthentication(AuthenticationContext filterContext)
        {
            ViewBag.UserName = AbpSession.GetUserName();
            base.OnAuthentication(filterContext);
        }
    }
}