﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Enterprises.CMS.NewsType.Dto;
using Webdiyer.WebControls.Mvc;
using Enterprises.CMS.Entities;

namespace Enterprises.CMS.NewsType
{
    /// <summary>
    /// 菜单类型业务逻辑服务类
    /// </summary>
    public class NewsTypeAppService : CMSAppServiceBase, INewsTypeAppService
    {
        private readonly IRepository<NewsTypeEntity, long> _newsTypeRepository;
        private readonly IPermissionManager _permissionManager;

        /// <summary>
        /// 构造函数
        /// </summary>
        public NewsTypeAppService(IRepository<NewsTypeEntity, long> fNewsTypeRepository, IPermissionManager permissionManager)
        {
            _newsTypeRepository = fNewsTypeRepository;
            _permissionManager = permissionManager;
        }

        /// <summary>
        /// 创建记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<long> Create(NewsTypeCreateInput model)
        {
            var entity = model.MapTo<NewsTypeEntity>();
            //entity.TenantId = 1;
            var id = await _newsTypeRepository.InsertAndGetIdAsync(entity);
            return id;
        }

        /// <summary>
        /// 根据ID删除记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task Delete(long id)
        {
            await _newsTypeRepository.DeleteAsync(id);
        }

        /// <summary>
        /// 根据ID获取记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<NewsTypeCreateInput> GetSingle(long id)
        {
             var entity= await _newsTypeRepository.GetAsync(id);
            return entity.MapTo<NewsTypeCreateInput>();
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task Edit(NewsTypeCreateInput model)
        {
            var entity = await _newsTypeRepository.GetAsync(model.Id);
            entity.TypeName = model.TypeName;
            entity.TypeCode = model.TypeCode;
            entity.ShowMenu = model.ShowMenu;
            entity.SortOrder = model.SortOrder;
            await _newsTypeRepository.UpdateAsync(entity);
        }

        public Task<List<NewsTypeListDto>> GetAll()
        {
            var list = _newsTypeRepository.GetAll().ToList();
            var result = list.MapTo<List<NewsTypeListDto>>();
            return Task.FromResult(result);
        }

        /// <summary>
        /// 分页请求
        /// </summary>
        /// <param name="input"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<PagedList<NewsTypeListDto>> List(NewsTypeSearchInput input, int id)
        {
            int pageSize = 10;
            var query = _newsTypeRepository.GetAll()
                       .WhereIf(!string.IsNullOrEmpty(input.TypeName),t => t.TypeName.Contains(input.TypeName) || t.TypeCode.Contains(input.TypeName));
            int totalCount;
            var list = query.OrderBy(p => p.SortOrder).PageBy(id, pageSize, out totalCount);
            PagedList<NewsTypeListDto> result = new PagedList<NewsTypeListDto>(list.MapTo<List<NewsTypeListDto>>(), id, pageSize, totalCount);
            return Task.FromResult(result);
        }
    }
}
