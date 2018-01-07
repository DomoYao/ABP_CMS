using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;

namespace Enterprises.CMS.Entities
{
    /// <summary>
    /// 文件表
    /// </summary>
    [Table("Files")]
    public class FilesEntity : AuditedEntity<long>
    {
        ///<summary>
        /// 文件批次ID（简称：文件夹ID）
        ///</summary>
        [Required]
        public virtual string FolderId { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        public virtual string FileName { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        public virtual string FileSize { get; set; }

        /// <summary>
        /// 文件扩展名
        /// </summary>
        public virtual string Extension { get; set; }

        /// <summary>
        /// 本地路径
        /// </summary>
        public virtual string FilePath { get; set; }

        ///<summary>
        /// 存储方式，null 本地，1 阿里云，2 ...
        ///</summary>
        public virtual int StorageType { get; set; }

        ///<summary>
        ///存储第三方时候的第三方ID
        ///</summary>
        public virtual string StorageId { get; set; }

        ///<summary>
        ///附件上传成功or失败标志位
        ///</summary>
        public virtual long? UploadFlag { get; set; }

    
        
    }
}
