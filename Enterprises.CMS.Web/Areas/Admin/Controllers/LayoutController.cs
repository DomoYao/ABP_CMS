using System.Web.Mvc;
using Abp.Application.Navigation;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.Threading;
using Enterprises.CMS.Sessions;
using Enterprises.CMS.Web.Areas.Admin.Models;

namespace Enterprises.CMS.Web.Areas.Admin.Controllers
{
    public class LayoutController : CmsAdminControllerBase
    {
        // GET: Admin/Layout
        private readonly IUserNavigationManager _userNavigationManager;
        private readonly ILocalizationManager _localizationManager;
        private readonly ISessionAppService _sessionAppService;
        private readonly IMultiTenancyConfig _multiTenancyConfig;

        public LayoutController(
            IUserNavigationManager userNavigationManager,
            ILocalizationManager localizationManager,
            ISessionAppService sessionAppService,
            IMultiTenancyConfig multiTenancyConfig)
        {
            _userNavigationManager = userNavigationManager;
            _localizationManager = localizationManager;
            _sessionAppService = sessionAppService;
            _multiTenancyConfig = multiTenancyConfig;
        }

        [ChildActionOnly]
        public PartialViewResult LeftMenu(string activeMenu = "")
        {
            var model = new LeftMenuViewModel
            {
                MainMenu = AsyncHelper.RunSync(() => _userNavigationManager.GetMenuAsync("MainMenu", AbpSession.UserId)),
                ActiveMenuItemName = activeMenu
            };

            return PartialView("_LeftMenu", model);
        }
    }
}