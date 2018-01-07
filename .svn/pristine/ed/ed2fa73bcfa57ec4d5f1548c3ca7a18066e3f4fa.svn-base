using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Enterprises.CMS.Users;

namespace Enterprises.CMS.UserList.Dto
{
    [AutoMapFrom(typeof (User))]
    [AutoMapTo(typeof(User))]
    public class UserInfoDto : EntityDto<long>
    {

        /// <summary>
        /// 名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 姓
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// 最后登入时间
        /// </summary>
        public DateTime? LastLoginTime { get; set; }
        /// <summary>
        /// 是否有效
        /// </summary>
        public bool IsActive { get; set; }

    }
}
