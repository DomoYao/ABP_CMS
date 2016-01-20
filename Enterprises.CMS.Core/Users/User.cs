using Abp.Authorization.Users;
using Enterprises.CMS.MultiTenancy;

namespace Enterprises.CMS.Users
{
    public class User : AbpUser<Tenant, User>
    {

    }
}