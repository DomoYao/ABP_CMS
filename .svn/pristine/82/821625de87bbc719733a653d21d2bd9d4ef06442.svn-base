using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Enterprises.CMS.Roles.Dto;
using Webdiyer.WebControls.Mvc;

namespace Enterprises.CMS.Roles
{
    /// <summary>
    /// 角色业务逻辑接口
    /// </summary>
    public interface IRoleAppService : IApplicationService
    {
        /// <summary>
        /// 新建
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<int> Create(CreateRoleInput model);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Delete(int id);

        /// <summary>
        /// 根据ID获取记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<CreateRoleInput> GetSingle(int id);

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task Edit(CreateRoleInput model);

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="searchModel"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<PagedList<RoleListDto>> List(RoleSearchInput searchModel, int id);
    }
}
