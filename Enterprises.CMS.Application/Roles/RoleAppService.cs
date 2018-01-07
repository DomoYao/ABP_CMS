using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Enterprises.CMS.Roles.Dto;
using Webdiyer.WebControls.Mvc;
using Enterprises.CMS.Authorization.Roles;

namespace Enterprises.CMS.Roles
{
    /// <summary>
    /// 角色业务逻辑服务类
    /// </summary>
    public class RoleAppService : CMSAppServiceBase, IRoleAppService
    {
        private readonly IRepository<Role, int> _roleRepository;
        private readonly IPermissionManager _permissionManager;

        public RoleAppService(IRepository<Role, int> roleRepository, IPermissionManager permissionManager)
        {
            _roleRepository = roleRepository;
            _permissionManager = permissionManager;
        }

        public async Task<int> Create(CreateRoleInput model)
        {
            var entity = model.MapTo<Role>();
            entity.TenantId = 1;
            var userid = await _roleRepository.InsertAndGetIdAsync(entity);
            return userid;
        }

        public async Task Delete(int id)
        {
            await _roleRepository.DeleteAsync(id);
        }

        public async Task<CreateRoleInput> GetSingle(int id)
        {
             var entity= await _roleRepository.GetAsync(id);
            return entity.MapTo<CreateRoleInput>();
        }

        public async Task Edit(CreateRoleInput model)
        {
            var entity = await _roleRepository.GetAsync(model.Id);
            entity.Name = model.Name;
            entity.DisplayName = model.DisplayName;
            await  _roleRepository.UpdateAsync(entity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<PagedList<RoleListDto>> List(RoleSearchInput input, int id)
        {
            int pageSize = 10;
            var query = _roleRepository.GetAll().WhereIf(!string.IsNullOrEmpty(input.Name),
                t => t.Name.Contains(input.Name) || t.DisplayName.Contains(input.Name));
            int totalCount;
            var list = query.OrderBy(p => p.Name).PageBy(id, pageSize, out totalCount);
            PagedList<RoleListDto> result = new PagedList<RoleListDto>(list.MapTo<List<RoleListDto>>(), id, pageSize, totalCount);
            return Task.FromResult(result);
        }
    }
}
