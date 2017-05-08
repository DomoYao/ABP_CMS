using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Enterprises.CMS.UserList;
using Microsoft.Owin.Security;

namespace Enterprises.CMS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class UsersController : CMSControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }


        /// <summary>
        /// 用户列表
        /// </summary>
        /// <returns></returns>
        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetUsers();
            return View(output);
        }
    }

  
}