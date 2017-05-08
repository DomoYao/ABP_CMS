using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Dependency;
using Abp.Runtime.Session;
using Enterprises.CMS.MultiTenancy;
using Enterprises.CMS.Users;

namespace Enterprises.CMS
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class CMSAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }



        protected CMSAppServiceBase()
        {
            LocalizationSourceName = CMSConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }
    }
}