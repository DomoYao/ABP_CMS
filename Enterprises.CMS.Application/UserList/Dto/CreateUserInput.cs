using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
using Abp.AutoMapper;
using Enterprises.CMS.Users;

namespace Enterprises.CMS.UserList.Dto
{
    [AutoMap(typeof(User))]
    public class CreateUserInput
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(User.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(User.MaxSurnameLength)]
        public string Surname { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(User.MaxPlainPasswordLength)]
        public string Password { get; set; }

        public bool IsActive { get; set; }
    }
}