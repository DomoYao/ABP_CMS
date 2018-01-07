using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace Enterprises.CMS.UserList.Dto
{
    /// <summary>
    /// 用户查询输入
    /// </summary>
    public class UsersSearchInput
    {
        /// <summary>
        /// 查询名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Moble { get; set; }
        /// <summary>
        /// 页面序号
        /// </summary>
        public int PageIndex { get; set; }
    }

   
}
