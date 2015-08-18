using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using Enterprises.CMS.EntityFramework;
using Enterprises.CMS.Migrations;

namespace Enterprises.CMS
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(CMSCoreModule))]
    public class CMSDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
           
        }
    }
}
