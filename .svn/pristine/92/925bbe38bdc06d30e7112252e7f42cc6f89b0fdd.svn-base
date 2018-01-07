using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Authorization;
using Abp.Web.Mvc.Authorization;
using Abp.Web.Mvc.Extensions;
using Enterprises.CMS.UserList;
using Enterprises.CMS.UserList.Dto;

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
        [AbpMvcAuthorize("Administration.Users")]
        public ActionResult Index(int id=1)
        {
            UsersSearchInput model=new UsersSearchInput();
            model.PageIndex = id;
            return View(model);
        }

        [AbpMvcAuthorize("Administration.Users")]
        [HttpGet]
        public ActionResult List(int id = 1)
        {
            var list = _userAppService.List(new UsersSearchInput(), id);
            return PartialView("_PageTable", list);
        }

        [AbpMvcAuthorize("Administration.Users")]
        [HttpPost]
        public ActionResult List(UsersSearchInput searchModel, int id = 1)
        {
            var list = _userAppService.List(searchModel, id);
            return PartialView("_PageTable", list);
        }

        /// <summary>
        /// 用户列表
        /// </summary>
        /// <returns></returns>
        [AbpMvcAuthorize("Administration.Users")]
        public PartialViewResult Create()
        {
            CreateUserInput model = new CreateUserInput();
            return PartialView(model);

        }

        /// <summary>
        /// 用户列表
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AbpMvcAuthorize("Administration.Users")]
        public JsonResult Create(CreateUserInput model)
        {
            if (ModelState.IsValid)
            {
                _userAppService.Create(model);
                return Json(new {result = true, errors = ""});
            }

            return Json(new { result = false, errors = ModelState.AllModelStateErrors()});
        }

        [AbpMvcAuthorize("Administration.Users")]
        public ActionResult Edit(long id)
        {
            CreateUserInput model = _userAppService.GetSingle(id);
            return PartialView(model);
        }

        [HttpPost]
        [AbpMvcAuthorize("Administration.Users")]
        public JsonResult Edit(CreateUserInput model)
        {
            if (ModelState.IsValid)
            {
                _userAppService.Edit(model);
                return Json(new { result = true, errors = "" });
            }

            return Json(new { result = false, errors = ModelState.AllModelStateErrors() });
        }

        [HttpGet]
        [AbpMvcAuthorize("Administration.Users")]
        public ActionResult Delete(long id)
        {
            _userAppService.Delete(id);
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);
        }

    }

  
}