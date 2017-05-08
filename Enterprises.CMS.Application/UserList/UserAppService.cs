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

      

        public async Task<ListResultDto<UserListDto>> GetUsers()
        {
            var users = await _userRepository.GetAllListAsync();

            return new ListResultDto<UserListDto>(users.MapTo<List<UserListDto>>());
        }

       
    }
}