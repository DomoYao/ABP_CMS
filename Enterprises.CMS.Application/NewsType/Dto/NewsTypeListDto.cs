using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Enterprises.CMS.NewsType;

namespace Enterprises.CMS.NewsType.Dto
{
    [AutoMap(typeof(Entities.NewsTypeEntity))]
    public class NewsTypeListDto:EntityDto<long>
    {
        /// <summary>
        /// 新闻类型
        /// </summary>
        public String TypeName { get; set; }

        /// <summary>
        /// 新闻编号
        /// </summary>
        public String TypeCode { get; set; }

        /// <summary>
        /// 在菜单显示
        /// </summary>
        public Boolean ShowMenu { get; set; }

        /// <summary>
        /// 排序顺序
        /// </summary>
        public Int32 SortOrder { get; set; }

    }
}