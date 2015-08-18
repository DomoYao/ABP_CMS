﻿using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.Configuration.Startup;
using Abp.UI;
using Abp.Web.Mvc.Models;
using Enterprises.CMS.Users;
using Enterprises.CMS.Web.Models.Account;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace Enterprises.CMS.Web.Controllers
{
    public class AccountController : CMSControllerBase
    {
        private readonly UserManager _userManager;
        private readonly IMultiTenancyConfig _multiTenancyConfig;

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }

        public AccountController(UserManager userManager, IMultiTenancyConfig multiTenancyConfig)
        {
            _userManager = userManager;
            _multiTenancyConfig = multiTenancyConfig;
        }

        public ActionResult Login(string returnUrl = "")
        {
            if (string.IsNullOrWhiteSpace(returnUrl))
            {
                returnUrl = Request.ApplicationPath;
            }

            return View(
                new LoginFormViewModel
                {
                    ReturnUrl = returnUrl,
                    IsMultiTenancyEnabled = _multiTenancyConfig.IsEnabled
                });
        }

        [HttpPost]
        [DisableAuditing]
        public async Task<JsonResult> Login(LoginViewModel loginModel, string returnUrl = "")
        {
            if (!ModelState.IsValid)
            {
                throw new UserFriendlyException("Your form is invalid!");
            }

            var loginResult = await _userManager.LoginAsync(
                loginModel.UsernameOrEmailAddress,
                loginModel.Password,
                loginModel.TenancyName
                );

            switch (loginResult.Result)
            {
                case AbpLoginResultType.Success:
                    break;
                case AbpLoginResultType.InvalidUserNameOrEmailAddress:
                case AbpLoginResultType.InvalidPassword:
                    throw new UserFriendlyException("Invalid user name or password!");
                case AbpLoginResultType.InvalidTenancyName:
                    throw new UserFriendlyException("No tenant with name: " + loginModel.TenancyName);
                case AbpLoginResultType.TenantIsNotActive:
                    throw new UserFriendlyException("Tenant is not active: " + loginModel.TenancyName);
                case AbpLoginResultType.UserIsNotActive:
                    throw new UserFriendlyException("User is not active: " + loginModel.UsernameOrEmailAddress);
                case AbpLoginResultType.UserEmailIsNotConfirmed:
                    throw new UserFriendlyException("Your email address is not confirmed!");
                default: //Can not fall to default for now. But other result types can be added in the future and we may forget to handle it
                    throw new UserFriendlyException("Unknown problem with login: " + loginResult.Result);
            }

            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);
            AuthenticationManager.SignIn(new AuthenticationProperties { IsPersistent = loginModel.RememberMe }, loginResult.Identity);

            if (string.IsNullOrWhiteSpace(returnUrl))
            {
                returnUrl = Request.ApplicationPath;
            }

            return Json(new MvcAjaxResponse { TargetUrl = returnUrl });
        }

        public ActionResult Logout()
        {
            AuthenticationManager.SignOut();
            return RedirectToAction("Login");
        }
    }
}