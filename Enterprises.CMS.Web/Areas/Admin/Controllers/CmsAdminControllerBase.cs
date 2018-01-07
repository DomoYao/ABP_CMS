using System.Web.Mvc.Filters;
using Abp.Runtime.Session;
using Abp.Web.Mvc.Controllers;
using Enterprises.CMS.Sessions;
using Enterprises.CMS.Sessions.Dto;

namespace Enterprises.CMS.Web.Areas.Admin.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class CmsAdminControllerBase : AbpController
    {
        public readonly ISessionAppService SessionService;

        protected CmsAdminControllerBase()
        {
            LocalizationSourceName = CMSConsts.LocalizationSourceName;
            SessionService = new SessionAppService();
        }


        protected override void OnAuthentication(AuthenticationContext filterContext)
        {
            ViewBag.UserName = AbpSession.GetUserName();
            base.OnAuthentication(filterContext);
        }

        public string UserName => AbpSession.GetUserName();
        public long UserId => AbpSession.GetUserId();

        public UserLoginInfoDto CurrentUser
        {
            get
            {
                var user = SessionService.GetCurrentLoginInformations();
                return user.Result.User;
            }
        }
    }
}