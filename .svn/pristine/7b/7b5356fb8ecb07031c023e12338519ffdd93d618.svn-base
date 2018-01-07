using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using Abp.Web.Mvc.Extensions;
using Enterprises.CMS.News;
using Enterprises.CMS.News.Dto;
using Enterprises.CMS.NewsType;


namespace Enterprises.CMS.Web.Areas.Admin.Controllers
{
    /// <summary>
    /// News
    /// </summary>
    [AbpMvcAuthorize]
    public class NewsController :  CmsAdminControllerBase
    {
        private readonly INewsAppService _newsAppService;
        private readonly INewsTypeAppService _newsTypeAppService;


        /// <summary>
        /// 构造函数
        /// </summary>
        public NewsController(INewsAppService fNewsAppService, INewsTypeAppService fnewsTypeAppService)
        {
            _newsAppService = fNewsAppService;
            _newsTypeAppService = fnewsTypeAppService;
        }


        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        //[AbpMvcAuthorize("Administration.News")]
        public ActionResult Index(int id = 1)
        {
            var model = new NewsSearchInput();
            model.PageIndex = id;
            return View(model);
        }

        //[AbpMvcAuthorize("Administration.News")]
        [HttpGet]
        public async Task<ActionResult> List(int id = 1)
        {
            var list = await _newsAppService.List(new NewsSearchInput(), id);
            return PartialView("_PageTable", list);
        }

        //[AbpMvcAuthorize("Administration.News")]
        [HttpPost]
        public async Task<ActionResult> List(NewsSearchInput searchModel, int id = 1)
        {
            var list = await _newsAppService.List(searchModel, id);
            return PartialView("_PageTable", list);
        }

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        //[AbpMvcAuthorize("Administration.News")]
        public ViewResult Create()
        {
            var model = new NewsCreateInput
            {
                DdlTypeItems = _newsTypeAppService.GetAll().Result
                    .Select(p => new SelectListItem{Text = p.TypeName, Value = p.Id.ToString() }).ToList(),
                ThumbMediaId = Guid.NewGuid().ToString()
            };

            return View(model);

        }

        /// <summary>
        /// 用户列表
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        //[AbpMvcAuthorize("Administration.News")]
        public async Task<JsonResult> Create(NewsCreateInput model)
        {
            if (ModelState.IsValid)
            {
                await _newsAppService.Create(model);
                return Json(new { result = true, errors = "" });
            }


            model.DdlTypeItems = _newsTypeAppService.GetAll().Result
                .Select(p => new SelectListItem {Text = p.TypeName, Value = p.Id.ToString() }).ToList();
           
            return Json(new { result = false, errors = ModelState.AllModelStateErrors() });
        }

        //[AbpMvcAuthorize("Administration.News")]
        public async Task<ActionResult> Edit(int id)
        {
            var model =await _newsAppService.GetSingle(id);
            model.DdlTypeItems = _newsTypeAppService.GetAll().Result
                .Select(p => new SelectListItem { Text = p.TypeName, Value = p.Id.ToString() }).ToList();

            return PartialView(model);
        }

        [HttpPost]
        //[AbpMvcAuthorize("Administration.News")]
        public async Task<JsonResult> Edit(NewsCreateInput model)
        {
            if (ModelState.IsValid)
            {
                await _newsAppService.Edit(model);
                return Json(new { result = true, errors = "" });
            }

            model.DdlTypeItems = _newsTypeAppService.GetAll().Result
                .Select(p => new SelectListItem { Text = p.TypeName, Value = p.Id.ToString() }).ToList();

            return Json(new { result = false, errors = ModelState.AllModelStateErrors() });
        }

        [HttpGet]
        //[AbpMvcAuthorize("Administration.News")]
        public async Task<ActionResult> Delete(int id)
        {
            await _newsAppService.Delete(id);
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);
        }

    }
}