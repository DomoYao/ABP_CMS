using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Abp.AutoMapper;

namespace Enterprises.CMS.News.Dto
{
    [AutoMap(typeof(Entities.NewsEntity))]
    public class NewsCreateInput
    {
         [Required(ErrorMessage = "请输入{0}！")]
        [DisplayName("新闻主题")]
        public String Title { get; set; }

        [Required(ErrorMessage = "请输入{0}！")]
        [DisplayName("图文消息的摘要，仅有单图文消息才有摘要，多图文此处为空")]
        public String Digest { get; set; }

        [Required(ErrorMessage = "请输入{0}！")]
        [DisplayName("作者")]
        public String Author { get; set; }

        [Required(ErrorMessage = "请输入{0}！")]
        [DisplayName("内容")]
        public String Content { get; set; }

        [Required(ErrorMessage = "请输入{0}！")]
        [DisplayName("图文消息的封面图片素材id")]
        public String ThumbMediaId { get; set; }

        [Required(ErrorMessage = "请输入{0}！")]
        [DisplayName("是否显示封面，0为false，即不显示，1为true，即显示")]
        public Boolean ShowCoverPic { get; set; }

        [Required(ErrorMessage = "请输入{0}！")]
        [DisplayName("是否打开评论，0不打开，1打开")]
        public Boolean NeedOpenComment { get; set; }

        [Required(ErrorMessage = "请输入{0}！")]
        [DisplayName("是否粉丝才可评论，0所有人可评论，1粉丝才可评论")]
        public Boolean OnlyFansCanComment { get; set; }

        [DisplayName("原文连接")]
        public String ContentSourceUrl { get; set; }

        [Required(ErrorMessage = "请输入{0}！")]
        [DisplayName("排序顺序")]
        public Int32 SortOrder { get; set; }

        public IList<SelectListItem> DdlTypeItems { get; set; }

        public long Id { get; set; }
        /// <summary>
        /// 新闻类型
        /// </summary>
        public long NewsTypeId { get; set; }
    }
}