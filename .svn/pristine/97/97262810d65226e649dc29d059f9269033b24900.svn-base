using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Enterprises.CMS.News.Dto;
using Webdiyer.WebControls.Mvc;

namespace Enterprises.CMS.News
{
    /// <summary>
    ///新闻公共管理逻辑接口
    /// </summary>
    public interface INewsAppService : IApplicationService
    {
        /// <summary>
        /// 新建
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<long> Create(NewsCreateInput model);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Delete(long id);

        /// <summary>
        /// 根据ID获取记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<NewsCreateInput> GetSingle(long id);

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task Edit(NewsCreateInput model);

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="searchModel"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<PagedList<NewsListDto>> List(NewsSearchInput searchModel, int id);
    }
}