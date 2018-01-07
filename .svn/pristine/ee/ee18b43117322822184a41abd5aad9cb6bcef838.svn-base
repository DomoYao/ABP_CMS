using Abp.Authorization;
using Enterprises.CMS.Authorization.Roles;
using Enterprises.CMS.MultiTenancy;
using Enterprises.CMS.Users;

namespace Enterprises.CMS.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
