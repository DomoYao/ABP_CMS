using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Enterprises.CMS.Authorization.Roles;
using Enterprises.CMS.Users;

namespace Enterprises.CMS.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(IRepository<Tenant> tenantRepository)
            : base(tenantRepository)
        {

        }
    }
}