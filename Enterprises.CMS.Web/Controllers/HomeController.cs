using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Enterprises.CMS.Sessions;

namespace Enterprises.CMS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : CMSControllerBase
    {

        public async Task<ActionResult> Index()
        {
            return View(); 
        }

    }
}