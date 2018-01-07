using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Enterprises.CMS.News;

namespace Enterprises.CMS.News.Dto
{
    [AutoMap(typeof(Entities.NewsEntity))]
    public class NewsListDto:EntityDto<long>
    {
         /// <summary>
        /// 新闻主题
        /// </summary>
        public String Title { get; set; }


    }
}