using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace Enterprises.CMS.NewsType.Dto
{
    [AutoMap(typeof(Entities.NewsTypeEntity))]
    public class NewsTypeCreateInput
    {
        [Required(ErrorMessage = "请输入{0}！")]
        [StringLength(100)]
        [DisplayName("新闻类型")]
        public string TypeName { get; set; }

        [Required(ErrorMessage = "请输入{0}！")]
        [DisplayName("新闻编号")]
        [StringLength(100)]
        public string TypeCode { get; set; }

        [Required(ErrorMessage = "请输入{0}！")]
        [DisplayName("在菜单显示")]
        public bool ShowMenu { get; set; }


        [DisplayName("排序顺序")]
        public int SortOrder { get; set; }

        public long Id { get; set; }
    }
}