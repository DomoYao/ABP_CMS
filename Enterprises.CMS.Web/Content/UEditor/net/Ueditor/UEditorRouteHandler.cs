using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Enterprises.CMS.Web.Content.net.Ueditor
{
    public class UEditorRouteHandler: IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new UEditorHandler();
        }
    }
}