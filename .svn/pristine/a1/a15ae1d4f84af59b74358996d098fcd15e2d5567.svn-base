using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Abp.Web.Mvc.Extensions;
using Enterprises.CMS.Roles;
using Enterprises.CMS.Roles.Dto;



namespace Enterprises.CMS.Web.Areas.Admin.Controllers
{
    [AbpMvcAuthorize]
    public class RoleController :  CmsAdminControllerBase
    {
        private readonly IRoleAppService _roleAppService;

        public RoleController(IRoleAppService roleAppService)
        {
            _roleAppService = roleAppService;
        }


        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        //[AbpMvcAuthorize("Administration.Role")]
        public ActionResult Index(int id = 1)
        {
            RoleSearchInput model = new RoleSearchInput();
            model.PageIndex = id;
            return View(model);
        }

        //[AbpMvcAuthorize("Administration.Role")]
        [HttpGet]
        public async Task<ActionResult> List(int id = 1)
        {
            var list = await _roleAppService.List(new RoleSearchInput(), id);
            return PartialView("_PageTable", list);
        }

        //[AbpMvcAuthorize("Administration.Role")]
        [HttpPost]
        public async Task<ActionResult> List(RoleSearchInput searchModel, int id = 1)
        {
            var list = await _roleAppService.List(searchModel, id);
            return PartialView("_PageTable", list);
        }

        /// <summary>
        /// 用户列表
        /// </summary>
        /// <returns></returns>
        //[AbpMvcAuthorize("Administration.Role")]
        public PartialViewResult Create()
        {
            var model = new CreateRoleInput();
            return PartialView(model);

        }

        /// <summary>
        /// 用户列表
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[AbpMvcAuthorize("Administration.Role")]
        public async Task<JsonResult> Create(CreateRoleInput model)
        {
            if (ModelState.IsValid)
            {
                await _roleAppService.Create(model);
                return Json(new { result = true, errors = "" });
            }

            return Json(new { result = false, errors = ModelState.AllModelStateErrors() });
        }

        //[AbpMvcAuthorize("Administration.Role")]
        public async Task<ActionResult> Edit(int id)
        {
            var model =await _roleAppService.GetSingle(id);
            return PartialView(model);
        }

        [HttpPost]
        //[AbpMvcAuthorize("Administration.Role")]
        public async Task<JsonResult> Edit(CreateRoleInput model)
        {
            if (ModelState.IsValid)
            {
                await _roleAppService.Edit(model);
                return Json(new { result = true, errors = "" });
            }

            return Json(new { result = false, errors = ModelState.AllModelStateErrors() });
        }

        [HttpGet]
        //[AbpMvcAuthorize("Administration.Role")]
        public async Task<ActionResult> Delete(int id)
        {
            await _roleAppService.Delete(id);
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);
        }

    }
}