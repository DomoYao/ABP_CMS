using Abp.MultiTenancy;
using Enterprises.CMS.Users;

namespace Enterprises.CMS.MultiTenancy
{
    public class Tenant : AbpTenant<Tenant, User>
    {

    }
}