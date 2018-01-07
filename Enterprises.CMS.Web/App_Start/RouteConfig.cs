using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Enterprises.CMS.Web.Content.net.Ueditor;

namespace Enterprises.CMS.Web
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.Add(new Route("Content/UEditor/{controller}", new UEditorRouteHandler()));
            //ASP.NET Web API Route Config
            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces:new[] { "Enterprises.CMS.Web.Controllers" }
            );
        }
    }
}
