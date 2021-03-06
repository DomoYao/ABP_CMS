﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Enterprises.CMS.NewsType.Dto;
using Webdiyer.WebControls.Mvc;

namespace Enterprises.CMS.NewsType
{
    /// <summary>
    ///菜单类型逻辑接口
    /// </summary>
    public interface INewsTypeAppService : IApplicationService
    {
        /// <summary>
        /// 新建
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<long> Create(NewsTypeCreateInput model);

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
        Task<NewsTypeCreateInput> GetSingle(long id);

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task Edit(NewsTypeCreateInput model);


        /// <summary>
        /// 获取所有列表
        /// </summary>
        /// <returns></returns>
        Task<List<NewsTypeListDto>> GetAll();

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="searchModel"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<PagedList<NewsTypeListDto>> List(NewsTypeSearchInput searchModel, int id);
    }
}