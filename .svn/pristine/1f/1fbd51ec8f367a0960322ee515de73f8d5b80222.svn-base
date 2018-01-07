using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Runtime.Session;
using Castle.MicroKernel.Registration;
using Enterprises.CMS.Sessions;

namespace Enterprises.CMS
{
    [DependsOn(typeof(CMSCoreModule), typeof(AbpAutoMapperModule))]
    public class CMSApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Configuration.MultiTenancy.IsEnabled = false;
            
        }
    }
}
