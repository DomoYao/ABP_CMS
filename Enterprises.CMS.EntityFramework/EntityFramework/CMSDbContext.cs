using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Enterprises.CMS.Authorization.Roles;
using Enterprises.CMS.MultiTenancy;
using Enterprises.CMS.Users;

namespace Enterprises.CMS.EntityFramework
{
    public class CMSDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public CMSDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in CMSDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of CMSDbContext since ABP automatically handles it.
         */
        public CMSDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public CMSDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
