using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using Enterprises.CMS.Users;

namespace Enterprises.CMS.Roles.Dto
{
    [AutoMap(typeof(Authorization.Roles.Role))]
    public class CreateRoleInput
    {
        [Required(ErrorMessage = "请输入{0}！")]
        [DisplayName("角色名称")]
        public string Name { get; set; }

        [Required(ErrorMessage = "请输入{0}！")]
        [DisplayName("角色显示名")]
        public string DisplayName { get; set; }

        public int Id { get; set; }
    }
}
