using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

    public static class UrlChecker
    {
        private static readonly Regex UrlWithProtocolRegex = new Regex("^.{1,10}://.*$");

        public static bool IsRooted(string url)
        {
            if (url.StartsWith("/"))
            {
                return true;
            }

            if (UrlWithProtocolRegex.IsMatch(url))
            {
                return true;
            }

            return false;
        }
    }
}