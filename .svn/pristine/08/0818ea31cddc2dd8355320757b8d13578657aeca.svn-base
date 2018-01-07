using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Enterprises.CMS.Files;

namespace Enterprises.CMS.Files.Dto
{
    [AutoMap(typeof(Entities.FilesEntity))]
    public class FilesListDto:EntityDto<long>
    {
        /// <summary>
        /// 文件批次ID（简称：文件夹ID）
        /// </summary>
        public  string FolderId { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        public  string FileName { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        public  string FileSize { get; set; }

        /// <summary>
        /// 文件扩展名
        /// </summary>
        public  string Extension { get; set; }

        /// <summary>
        /// 本地路径
        /// </summary>
        public  string FilePath { get; set; }

        ///<summary>
        /// 存储方式，null 本地，1 阿里云，2 ...
        ///</summary>
        public  int StorageType { get; set; }

        ///<summary>
        ///存储第三方时候的第三方ID
        ///</summary>
        public  string StorageId { get; set; }

        ///<summary>
        ///附件上传成功or失败标志位
        ///</summary>
        public  long? UploadFlag { get; set; }


    }
}