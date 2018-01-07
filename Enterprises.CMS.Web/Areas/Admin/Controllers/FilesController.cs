using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Enterprises.CMS.Files;
using Enterprises.CMS.Files.Dto;
using Enterprises.CMS.News;
using Enterprises.CMS.NewsType;

namespace Enterprises.CMS.Web.Areas.Admin.Controllers
{
    public class FilesController : CmsAdminControllerBase
    {
        private readonly List<string> ImageExts = new List<string>(){"jpeg","png","gif","jpg" };

        private readonly IFilesAppService _filesAppService;


        /// <summary>
        /// 构造函数
        /// </summary>
        public FilesController(IFilesAppService filesAppService)
        {
            _filesAppService = filesAppService;
        }


        /// <summary>
        /// 图片上传
        /// </summary>
        /// <returns></returns>
        public ActionResult ImgUpload()
        {
            var httpFileCollection = Request.Files;
            var newName = Request["fileName"];
            var fileSize = Request["fileSize"];
            var folderId = Request["folderId"];
            var aLastName = "";
            var filePath = "";
            if (string.IsNullOrEmpty(folderId) )
            {
                throw new Exception("folderId 不能为空");
            }

            foreach (string fileParam in httpFileCollection)
            {
                var file = httpFileCollection.Get(fileParam);
                if (file != null)
                {
                    var fileName = file.FileName;
                    aLastName = fileName.Substring(fileName.LastIndexOf(".", StringComparison.Ordinal) + 1, (fileName.Length - fileName.LastIndexOf(".", StringComparison.Ordinal) - 1));
                    if (!ImageExts.Contains(aLastName.ToLower()))
                    {
                        throw new Exception("只支持图片格式文件");
                    }

                    if (file.ContentLength > 0)
                    {
                        var originalDirectory = new DirectoryInfo($"{Server.MapPath(@"\")}Images");
                        string pathString = Path.Combine(originalDirectory.ToString(), folderId);
                        bool isExists = Directory.Exists(pathString);
                        if (!isExists)
                        {
                            Directory.CreateDirectory(pathString);
                        }

                        if (!string.IsNullOrEmpty(newName) && newName != fileName)
                        {
                            fileName = newName;
                        }

                        filePath = $"{pathString}\\{fileName}";
                        file.SaveAs(filePath);
                    }
                    else
                    {
                        throw new Exception("文件大小不能为空");
                    }
                }
            }

           var id=  _filesAppService.Create(new FilesCreateInput
            {
                FolderId = folderId,
                Extension = aLastName,
                FileSize = fileSize,
                FilePath = filePath,
                FileName = newName
            }).Result;

            return Json(new {result = true, fileId = id});
        }


       
    }
}
