using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Enterprises.CMS.UserList.Dto;

namespace Enterprises.CMS.UserList
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);


        Task<ListResultDto<UserListDto>> GetUsers();
        void Add(UserInfoDto model);
        void Delete(long id);
    }
}