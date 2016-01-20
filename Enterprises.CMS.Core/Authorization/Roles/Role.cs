using Abp.Authorization.Roles;
using Enterprises.CMS.MultiTenancy;
using Enterprises.CMS.Users;

namespace Enterprises.CMS.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}