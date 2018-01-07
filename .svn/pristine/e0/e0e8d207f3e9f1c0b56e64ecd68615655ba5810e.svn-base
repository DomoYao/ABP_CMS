using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Enterprises.CMS.Entities;
using Enterprises.CMS.Files.Dto;

namespace Enterprises.CMS.Files
{
    /// <summary>
    /// Files业务逻辑服务类
    /// </summary>
    public class FilesAppService : CMSAppServiceBase, IFilesAppService
    {
        private readonly IRepository<FilesEntity, long> _filesRepository;
        private readonly IPermissionManager _permissionManager;

        /// <summary>
        /// 构造函数
        /// </summary>
        public FilesAppService(IRepository<FilesEntity, long> fFilesRepository, IPermissionManager permissionManager)
        {
            _filesRepository = fFilesRepository;
            _permissionManager = permissionManager;
        }

        /// <summary>
        /// 创建记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<long> Create(FilesCreateInput model)
        {
            var entity = model.MapTo<FilesEntity>();
            //entity.TenantId = 1;
            var id = await _filesRepository.InsertAndGetIdAsync(entity);
            return id;
        }

        /// <summary>
        /// 根据ID删除记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task Delete(long id)
        {
            await _filesRepository.DeleteAsync(id);
        }

        /// <summary>
        /// 根据ID获取记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<FilesCreateInput> GetSingle(long id)
        {
             var entity= await _filesRepository.GetAsync(id);
            return entity.MapTo<FilesCreateInput>();
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task Edit(FilesCreateInput model)
        {
            var entity = await _filesRepository.GetAsync(model.Id);
            entity.FolderId = model.FolderId;
            entity.FileName = model.FileName;
            await  _filesRepository.UpdateAsync(entity);
        }

        /// <summary>
        /// 分页请求
        /// </summary>
        /// <param name="folderId"></param>
        /// <returns></returns>
        public Task<List<FilesListDto>> List(string folderId)
        {
            var query = _filesRepository.GetAll().Where(p => p.FolderId == folderId);
            var list = query.OrderBy(p => p.CreationTime);
            List<FilesListDto> result = list.MapTo<List<FilesListDto>>();
            return Task.FromResult(result);
        }
    }
}
