using System.Collections.Generic;
using System.Linq;

namespace Abp.Web.Mvc.Extensions
{
    /// <summary>
    /// 扩展ModelState验证，把ModelStateDictionary中的验证失败信息连同对应的属性读取出来
    /// </summary>
    public static class ModelStateExtensions
    {
        /// <summary>
        /// 获取所有的错误的验证信息
        /// </summary>
        /// <param name="modelState"></param>
        /// <returns></returns>
        public static IEnumerable<InputError> AllModelStateErrors(this System.Web.Mvc.ModelStateDictionary modelState)
        {
            var result = new List<InputError>();
            //找到出错的字段以及出错信息
            var errorFieldsAndMsgs = modelState.Where(m => m.Value.Errors.Any())
                .Select(x => new { x.Key, x.Value.Errors });
            foreach (var item in errorFieldsAndMsgs)
            {
                //获取键
                var fieldKey = item.Key;
                //获取键对应的错误信息
                var fieldErrors = item.Errors
                    .Select(e => new InputError(fieldKey, e.ErrorMessage));
                result.AddRange(fieldErrors);
            }
            return result;
        }
    }

    /// <summary>
    /// 输入错误
    /// </summary>
    public class InputError
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="key"></param>
        /// <param name="message"></param>
        public InputError(string key, string message)
        {
            Key = key;
            Message = message;
        }

        /// <summary>
        /// 表单属性
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string Message { get; set; }
    }
}
