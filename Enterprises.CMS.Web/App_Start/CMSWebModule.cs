﻿using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Abp.Localization;
using Abp.Localization.Sources.Xml;
using Abp.Modules;

namespace Enterprises.CMS.Web
{
    [DependsOn(typeof(CMSDataModule), typeof(CMSApplicationModule), typeof(CMSWebApiModule))]
    public class CMSWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Add/remove languages for your application
            //Configuration.Localization.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flag-england", true));
            //Configuration.Localization.Languages.Add(new LanguageInfo("tr", "Türkçe", "famfamfam-flag-tr"));
            Configuration.Localization.Languages.Add(new LanguageInfo("zh-CN", "简体中文", "famfamfam-flag-cn", true));

            //Add/remove localization sources here
            Configuration.Localization.Sources.Add(
                new XmlLocalizationSource(
                    CMSConsts.LocalizationSourceName,
                    HttpContext.Current.Server.MapPath("~/Localization/CMS")
                    )
                );

            //Configure navigation/menu
            Configuration.Navigation.Providers.Add<CMSNavigationProvider>();

            Configuration.MultiTenancy.IsEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
