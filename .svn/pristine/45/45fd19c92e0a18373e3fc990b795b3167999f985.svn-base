using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;
using Enterprises.CMS;

namespace Enterprise.CMS.Authorization
{
    public class CMSAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //Common permissions
            var admin = context.GetPermissionOrNull(PermissionNames.Administration) ??context.CreatePermission(PermissionNames.Administration, L("Administration"));

            var users = admin.CreateChildPermission(PermissionNames.AdministrationUsers, L("Administration.Users"));
            users.CreateChildPermission(PermissionNames.AdministrationUsersCreate, L("Administration.Users.Create"));
            users.CreateChildPermission(PermissionNames.AdministrationUsersEdit, L("Administration.Users.Edit"));
            users.CreateChildPermission(PermissionNames.AdministrationUsersDelete, L("Administration.Users.Delete"));

        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, CMSConsts.LocalizationSourceName);
        }
    }
}
