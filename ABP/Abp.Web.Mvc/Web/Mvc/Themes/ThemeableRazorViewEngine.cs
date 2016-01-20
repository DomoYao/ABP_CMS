using System.Web.Mvc;

namespace Abp.Web.Mvc.Themes
{
    public class ThemeableRazorViewEngine : ThemeableBuildManagerViewEngine
    {
        /*
~/Plugins/{PluginName}/Views/{Controller}/{ViewName}.cshtml
~/Plugins/{PluginName}/Themes/{ThemeName}/Views/{Controller}/{ViewName}.cshtml
~/Plugins/{PluginName}/Views/{Controller}/{ViewName}.cshtml
~/Plugins/{PluginName}/Themes/{ThemeName}/Views/{Controller}/{ViewName}.cshtml
~/Plugins/{PluginName}/Views/Shared/{ViewName}.cshtml
~/Plugins/{PluginName}/Themes/{ThemeName}/Views/Shared/{ViewName}.cshtml
         */
        /// <summary>
        /// {4},{3},{2},{1},{0}分别代表  PluginName, 模板名称  ,Area名，Controller名，Action名   
        /// </summary>
        public ThemeableRazorViewEngine()
        {
        AreaViewLocationFormats = new[]
                                        {
                                            
                                            "~/Themes/{3}/Views/{2}/{1}/{0}.cshtml",
                                            "~/Themes/{3}/Views/{2}/{1}/{0}.vbhtml",
                                            "~/Themes/{3}/Views/{2}/Shared/{0}.cshtml",
                                            "~/Themes/{3}/Views/{2}/Shared/{0}.vbhtml",

                                            "~/Plugins/{4}/Themes/{3}/Views/{2}/{1}/{0}.cshtml",
                                            "~/Plugins/{4}/Themes/{3}/Views/{2}/{1}/{0}.vbhtml",
                                            "~/Plugins/{4}/Themes/{3}/Views/Shared/{0}.cshtml",
                                            "~/Plugins/{4}/Themes/{3}/Views/Shared/{0}.vbhtml",
                                            "~/Plugins/{4}/Views/{2}/{1}/{0}.cshtml",
                                            "~/Plugins/{4}/Views/{2}/{1}/{0}.vbhtml",
                                            "~/Plugins/{4}/Views/Shared/{0}.cshtml",
                                            "~/Plugins/{4}/Views/Shared/{0}.vbhtml",
                                            

                                           
                                            "~/Areas/{2}/Views/{1}/{0}.cshtml",
                                            "~/Areas/{2}/Views/{1}/{0}.vbhtml",
                                            "~/Areas/{2}/Views/Shared/{0}.cshtml", 
                                            "~/Areas/{2}/Views/Shared/{0}.vbhtml"
                                        };
        AreaMasterLocationFormats = new[]
                                        {
                                            "~/Themes/{3}/Views/{2}/{1}/{0}.cshtml",
                                            "~/Themes/{3}/Views/{2}/{1}/{0}.vbhtml",
                                            "~/Themes/{3}/Views/{2}/Shared/{0}.cshtml",
                                            "~/Themes/{3}/Views/{2}/Shared/{0}.vbhtml",

                                            "~/Plugins/{4}/Themes/{3}/Views/{2}/{1}/{0}.cshtml",
                                            "~/Plugins/{4}/Themes/{3}/Views/{2}/{1}/{0}.vbhtml",
                                            "~/Plugins/{4}/Themes/{3}/Views/Shared/{0}.cshtml",
                                            "~/Plugins/{4}/Themes/{3}/Views/Shared/{0}.vbhtml",
                                            "~/Plugins/{4}/Views/{2}/{1}/{0}.cshtml",
                                            "~/Plugins/{4}/Views/{2}/{1}/{0}.vbhtml",
                                            "~/Plugins/{4}/Views/Shared/{0}.cshtml",
                                            "~/Plugins/{4}/Views/Shared/{0}.vbhtml",

                                            
                                            "~/Areas/{2}/Views/{1}/{0}.cshtml", 
                                            "~/Areas/{2}/Views/{1}/{0}.vbhtml",
                                            "~/Areas/{2}/Views/Shared/{0}.cshtml",
                                            "~/Areas/{2}/Views/Shared/{0}.vbhtml"
                                        };
            AreaPartialViewLocationFormats = new []
                                                 {
                                                     "~/Themes/{3}/Views/{2}/{1}/{0}.cshtml",
                                                     "~/Themes/{3}/Views/{2}/{1}/{0}.vbhtml",
                                                     "~/Themes/{3}/Views/{2}/Shared/{0}.cshtml",
                                                     "~/Themes/{3}/Views/{2}/Shared/{0}.vbhtml",

                                                     "~/Plugins/{4}/Themes/{3}/Views/{2}/{1}/{0}.cshtml",
                                                     "~/Plugins/{4}/Themes/{3}/Views/{2}/{1}/{0}.vbhtml",
                                                     "~/Plugins/{4}/Themes/{3}/Views/Shared/{0}.cshtml",
                                                     "~/Plugins/{4}/Themes/{3}/Views/Shared/{0}.vbhtml",
                                                     "~/Plugins/{4}/Views/{2}/{1}/{0}.cshtml",
                                                     "~/Plugins/{4}/Views/{2}/{1}/{0}.vbhtml",
                                                     "~/Plugins/{4}/Views/Shared/{0}.cshtml",
                                                     "~/Plugins/{4}/Views/Shared/{0}.vbhtml",

                                                     
                                                     "~/Areas/{2}/Views/{1}/{0}.cshtml",
                                                     "~/Areas/{2}/Views/{1}/{0}.vbhtml",
                                                     "~/Areas/{2}/Views/Shared/{0}.cshtml",
                                                     "~/Areas/{2}/Views/Shared/{0}.vbhtml"
            };
            ViewLocationFormats = new []
                                      {
                                          "~/Themes/{2}/Views/{1}/{0}.cshtml", 
                                          "~/Themes/{2}/Views/{1}/{0}.vbhtml",
                                          "~/Themes/{2}/Views/Shared/{0}.cshtml", 
                                          "~/Themes/{2}/Views/Shared/{0}.vbhtml",

                                          "~/Plugins/{3}/Themes/{2}/Views/{1}/{0}.cshtml",
                                          "~/Plugins/{3}/Themes/{2}/Views/{1}/{0}.vbhtml",
                                          "~/Plugins/{3}/Themes/{2}/Views/Shared/{0}.cshtml",
                                          "~/Plugins/{3}/Themes/{2}/Views/Shared/{0}.vbhtml",
                                          "~/Plugins/{3}/Views/{1}/{0}.cshtml",
                                          "~/Plugins/{3}/Views/{1}/{0}.vbhtml",
                                          "~/Plugins/{3}/Views/Shared/{0}.cshtml", 
                                          "~/Plugins/{3}/Views/Shared/{0}.vbhtml",

                                          
                                          "~/Views/{1}/{0}.cshtml", 
                                          "~/Views/{1}/{0}.vbhtml", 
                                          "~/Views/Shared/{0}.cshtml",
                                          "~/Views/Shared/{0}.vbhtml"
            };
            MasterLocationFormats = new[]
                                        {
                                            "~/Themes/{2}/Views/{1}/{0}.cshtml", 
                                            "~/Themes/{2}/Views/{1}/{0}.vbhtml",
                                            "~/Themes/{2}/Views/Shared/{0}.cshtml", 
                                            "~/Themes/{2}/Views/Shared/{0}.vbhtml",

                                            "~/Plugins/{3}/Themes/{2}/Views/{1}/{0}.cshtml",
                                          "~/Plugins/{3}/Themes/{2}/Views/{1}/{0}.vbhtml",
                                          "~/Plugins/{3}/Themes/{2}/Views/Shared/{0}.cshtml",
                                          "~/Plugins/{3}/Themes/{2}/Views/Shared/{0}.vbhtml",
                                          "~/Plugins/{3}/Views/{1}/{0}.cshtml",
                                          "~/Plugins/{3}/Views/{1}/{0}.vbhtml",
                                          "~/Plugins/{3}/Views/Shared/{0}.cshtml", 
                                          "~/Plugins/{3}/Views/Shared/{0}.vbhtml",

                                            
                                            "~/Views/{1}/{0}.cshtml",
                                            "~/Views/{1}/{0}.vbhtml",
                                            "~/Views/Shared/{0}.cshtml",
                                            "~/Views/Shared/{0}.vbhtml"
                                        };
            PartialViewLocationFormats = new[]
                                             {
                                                  "~/Themes/{2}/Views/{1}/{0}.cshtml", 
                                                 "~/Themes/{2}/Views/{1}/{0}.vbhtml",
                                                 "~/Themes/{2}/Views/Shared/{0}.cshtml",
                                                 "~/Themes/{2}/Views/Shared/{0}.vbhtml",

                                            "~/Plugins/{3}/Themes/{2}/Views/{1}/{0}.cshtml",
                                          "~/Plugins/{3}/Themes/{2}/Views/{1}/{0}.vbhtml",
                                          "~/Plugins/{3}/Themes/{2}/Views/Shared/{0}.cshtml",
                                          "~/Plugins/{3}/Themes/{2}/Views/Shared/{0}.vbhtml",
                                          "~/Plugins/{3}/Views/{1}/{0}.cshtml",
                                          "~/Plugins/{3}/Views/{1}/{0}.vbhtml",
                                          "~/Plugins/{3}/Views/Shared/{0}.cshtml", 
                                          "~/Plugins/{3}/Views/Shared/{0}.vbhtml",

                                                
                                                 "~/Views/{1}/{0}.cshtml",
                                                 "~/Views/{1}/{0}.vbhtml", 
                                                 "~/Views/Shared/{0}.cshtml",
                                                 "~/Views/Shared/{0}.vbhtml"
                                             };
            FileExtensions = new[] { "cshtml", "vbhtml" };
        }

        protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
        {
            var layoutPath = (string)null;
            var runViewStartPages = false;
            var fileExtensions = base.FileExtensions;
            return new RazorView(controllerContext, partialPath, layoutPath, runViewStartPages, fileExtensions);
        }

        protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
        {
            var layoutPath = masterPath;
            var runViewStartPages = true;
            var fileExtensions = base.FileExtensions;
            return new RazorView(controllerContext, viewPath, layoutPath, runViewStartPages, fileExtensions);
        }
    }
}