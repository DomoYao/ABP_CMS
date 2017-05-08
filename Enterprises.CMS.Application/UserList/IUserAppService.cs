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

    }
}