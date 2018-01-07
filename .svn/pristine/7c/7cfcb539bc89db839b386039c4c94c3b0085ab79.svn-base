using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Abp.Web.Mvc.Extensions;
using Enterprises.CMS.NewsType;
using Enterprises.CMS.NewsType.Dto;



namespace Enterprises.CMS.Web.Areas.Admin.Controllers
{
    /// <summary>
    /// 菜单类型
    /// </summary>
    [AbpMvcAuthorize]
    public class NewsTypeController :  CmsAdminControllerBase
    {
        private readonly INewsTypeAppService _newsTypeAppService;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fNewsTypeAppService"></param>
        public NewsTypeController(INewsTypeAppService fNewsTypeAppService)
        {
            _newsTypeAppService = fNewsTypeAppService;
        }


        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        //[AbpMvcAuthorize("Administration.NewsType")]
        public ActionResult Index(int id = 1)
        {
            var model = new NewsTypeSearchInput();
            model.PageIndex = id;
            return View(model);
        }

        //[AbpMvcAuthorize("Administration.NewsType")]
        [HttpGet]
        public async Task<ActionResult> List(int id = 1)
        {
            var list = await _newsTypeAppService.List(new NewsTypeSearchInput(), id);
            return PartialView("_PageTable", list);
        }

        //[AbpMvcAuthorize("Administration.NewsType")]
        [HttpPost]
        public async Task<ActionResult> List(NewsTypeSearchInput searchModel, int id = 1)
        {
            var list = await _newsTypeAppService.List(searchModel, id);
            return PartialView("_PageTable", list);
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        //[AbpMvcAuthorize("Administration.NewsType")]
        public PartialViewResult Create()
        {
            var model = new NewsTypeCreateInput();
            return PartialView(model);

        }

        /// <summary>
        /// 用户列表
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[AbpMvcAuthorize("Administration.NewsType")]
        public async Task<JsonResult> Create(NewsTypeCreateInput model)
        {
            if (ModelState.IsValid)
            {
                await _newsTypeAppService.Create(model);
                return Json(new { result = true, errors = "" });
            }

            return Json(new { result = false, errors = ModelState.AllModelStateErrors() });
        }

        //[AbpMvcAuthorize("Administration.NewsType")]
        public async Task<ActionResult> Edit(int id)
        {
            var model =await _newsTypeAppService.GetSingle(id);
            return PartialView(model);
        }

        [HttpPost]
        //[AbpMvcAuthorize("Administration.NewsType")]
        public async Task<JsonResult> Edit(NewsTypeCreateInput model)
        {
            if (ModelState.IsValid)
            {
                await _newsTypeAppService.Edit(model);
                return Json(new { result = true, errors = "" });
            }

            return Json(new { result = false, errors = ModelState.AllModelStateErrors() });
        }

        [HttpGet]
        //[AbpMvcAuthorize("Administration.NewsType")]
        public async Task<ActionResult> Delete(int id)
        {
            await _newsTypeAppService.Delete(id);
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);
        }

    }
}