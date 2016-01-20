using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Domain.Uow;
using Abp.Zero.Configuration;
using Enterprises.CMS.MultiTenancy;
using Enterprises.CMS.Users;

namespace Enterprises.CMS.Authorization.Roles
{
    public class RoleManager : AbpRoleManager<Tenant, Role, User>
    {
        public RoleManager(
            RoleStore store,
            IPermissionManager permissionManager,
            IRoleManagementConfig roleManagementConfig,
            IUnitOfWorkManager unitOfWorkManager)
            : base(
                store,
                permissionManager,
                roleManagementConfig,
                unitOfWorkManager)
        {
        }
    }
}