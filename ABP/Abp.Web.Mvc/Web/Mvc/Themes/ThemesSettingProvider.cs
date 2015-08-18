#region 文档操作记录
// 路径：Abp > Abp.Web.Mvc > ThemesSettingProvider.cs
// 说明：
//  
// 创建日期：2015/07/14
// 文档作者：饶杰
// 
// 更新日志: 
//  新增Theme功能.
#endregion

using System.Collections.Generic;
using Abp.Configuration;

namespace Abp.Web.Mvc.Themes
{
    public class ThemesSettingProvider : SettingProvider
    {
        public const string WorkingMobileThemeSettinKey = "WorkingMobileTheme";
        public const string WorkingDesktopThemeSettinKey = "WorkingDesktopTheme";
        public override IEnumerable<SettingDefinition> GetSettingDefinitions(SettingDefinitionProviderContext context)
        {
            return new[]
                {
                    new SettingDefinition(
                        WorkingMobileThemeSettinKey,
                        "Base.Moblie",
                        scopes: SettingScopes.Application | SettingScopes.Tenant|SettingScopes.User
                        ),

                    new SettingDefinition(
                        WorkingDesktopThemeSettinKey,
                        "Base",
                        scopes: SettingScopes.Application | SettingScopes.Tenant|SettingScopes.User
                        )
                };
        }
    }
}