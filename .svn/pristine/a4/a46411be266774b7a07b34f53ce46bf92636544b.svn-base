using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Enterprises.CMS.UserList;
using Microsoft.Owin.Security;
using Enterprises.CMS.Web.Models.Users;
using Enterprises.CMS.UserList.Dto;
using System;
using Abp.Web.Mvc.Controllers.Results;

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

        /// <summary>
        /// 用户列表
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Create(UserInfoDto model)
        {
            _userAppService.Add(model);
            return Json(new { result = true, message = "" });
        }

        [HttpGet]
        public ActionResult Delete(long id)
        {
            _userAppService.Delete(id);
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);
        }

    }

  
}