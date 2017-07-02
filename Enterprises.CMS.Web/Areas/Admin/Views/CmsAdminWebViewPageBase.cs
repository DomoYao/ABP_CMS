using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Abp.Web.Mvc.Views;

namespace Enterprises.CMS.Web.Areas.Admin.Views
{
    public abstract class CmsAdminWebViewPageBase : CmsAdminWebViewPageBase<dynamic>
    {

    }

    public abstract class CmsAdminWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected CmsAdminWebViewPageBase()
        {
            LocalizationSourceName = CMSConsts.LocalizationSourceName;
        }
    }
}