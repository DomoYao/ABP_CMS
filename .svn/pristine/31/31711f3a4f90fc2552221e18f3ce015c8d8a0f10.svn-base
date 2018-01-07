using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Enterprises.CMS.UserList.Dto;
using Enterprises.CMS.Users;

namespace Enterprises.CMS.UserList
{
    public class UserAppService : CMSAppServiceBase, IUserAppService
    {
        private readonly IRepository<User, long> _userRepository;
        private readonly IPermissionManager _permissionManager;

        public UserAppService(IRepository<User, long> userRepository, IPermissionManager permissionManager)
        {
            _userRepository = userRepository;
            _permissionManager = permissionManager;
        }

        public async Task ProhibitPermission(ProhibitPermissionInput input)
        {
            var user = await UserManager.GetUserByIdAsync(input.UserId);
            var permission = _permissionManager.GetPermission(input.PermissionName);

            await UserManager.ProhibitPermissionAsync(user, permission);
        }

      
        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>

        public async Task<ListResultDto<UserListDto>> GetUsers()
        {
            var users = await _userRepository.GetAllListAsync();

            return new ListResultDto<UserListDto>(users.MapTo<List<UserListDto>>());
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public void Add(UserInfoDto model)
        {
            var entity = model.MapTo<User>();
            entity.TenantId = 1;
            entity.IsEmailConfirmed = false;
            entity.IsMobileConfirmed = false;
            entity.Password = "123456";
            entity.Surname = entity.Name;
            entity.Mobile = "13606806123";
            var userid = _userRepository.InsertAndGetId(entity);
            Logger.Debug(userid.ToString);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        public void Delete(long id)
        {
            _userRepository.Delete(id);
        }
    }
}