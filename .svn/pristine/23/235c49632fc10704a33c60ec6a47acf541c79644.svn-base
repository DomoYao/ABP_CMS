using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Enterprises.CMS.News.Dto;
using Webdiyer.WebControls.Mvc;
using Enterprises.CMS.Entities;

namespace Enterprises.CMS.News
{
    /// <summary>
    /// 新闻公共管理业务逻辑服务类
    /// </summary>
    public class NewsAppService : CMSAppServiceBase, INewsAppService
    {
        private readonly IRepository<NewsEntity, long> _NewsRepository;
        private readonly IPermissionManager _permissionManager;

        /// <summary>
        /// 构造函数
        /// </summary>
        public NewsAppService(IRepository<NewsEntity, long> fNewsRepository, IPermissionManager permissionManager)
        {
            _NewsRepository = fNewsRepository;
            _permissionManager = permissionManager;
        }

        /// <summary>
        /// 创建记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<long> Create(NewsCreateInput model)
        {
            var entity = model.MapTo<NewsEntity>();
            //entity.TenantId = 1;
            var id = await _NewsRepository.InsertAndGetIdAsync(entity);
            return id;
        }

        /// <summary>
        /// 根据ID删除记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task Delete(long id)
        {
            await _NewsRepository.DeleteAsync(id);
        }

        /// <summary>
        /// 根据ID获取记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<NewsCreateInput> GetSingle(long id)
        {
             var entity= await _NewsRepository.GetAsync(id);
            return entity.MapTo<NewsCreateInput>();
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task Edit(NewsCreateInput model)
        {
            var entity = await _NewsRepository.GetAsync(model.Id);
            entity.Title = model.Title;
            entity.Digest = model.Digest;
            entity.Author = model.Author;
            entity.Content = model.Content;
            entity.ThumbMediaId = model.ThumbMediaId;
            entity.ShowCoverPic = model.ShowCoverPic;
            entity.NeedOpenComment = model.NeedOpenComment;
            entity.OnlyFansCanComment = model.OnlyFansCanComment;
            entity.ContentSourceUrl = model.ContentSourceUrl;
            entity.SortOrder = model.SortOrder;
            await  _NewsRepository.UpdateAsync(entity);
        }

        /// <summary>
        /// 分页请求
        /// </summary>
        /// <param name="input"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<PagedList<NewsListDto>> List(NewsSearchInput input, int id)
        {
            int pageSize = 10;
            var query = _NewsRepository.GetAll()
                       .WhereIf(!string.IsNullOrEmpty(input.Title),t => t.Title.Contains(input.Title));
            int totalCount;
            var list = query.OrderBy(p => p.SortOrder).PageBy(id, pageSize, out totalCount);
            PagedList<NewsListDto> result = new PagedList<NewsListDto>(list.MapTo<List<NewsListDto>>(), id, pageSize, totalCount);
            return Task.FromResult(result);
        }
    }
}
