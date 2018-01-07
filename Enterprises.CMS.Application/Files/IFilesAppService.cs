using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Enterprises.CMS.Files.Dto;
using Webdiyer.WebControls.Mvc;

namespace Enterprises.CMS.Files
{
    /// <summary>
    ///Files逻辑接口
    /// </summary>
    public interface IFilesAppService : IApplicationService
    {
        /// <summary>
        /// 新建
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<long> Create(FilesCreateInput model);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task Delete(long id);

        /// <summary>
        /// 根据ID获取记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<FilesCreateInput> GetSingle(long id);

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task Edit(FilesCreateInput model);

        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="folderId"></param>
        /// <returns></returns>
        Task<List<FilesListDto>> List(string folderId);
    }
}