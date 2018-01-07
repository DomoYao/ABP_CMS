using Abp.Web.Mvc.Views;

namespace Enterprises.CMS.Web.Views
{
    public abstract class CMSWebViewPageBase : CMSWebViewPageBase<dynamic>
    {

    }

    public abstract class CMSWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected CMSWebViewPageBase()
        {
            LocalizationSourceName = CMSConsts.LocalizationSourceName;
        }
    }
}