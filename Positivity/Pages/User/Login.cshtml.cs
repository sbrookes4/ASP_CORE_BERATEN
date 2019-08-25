using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Positivity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Positivity.Pages.User
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public UserLogin UserLogin { get; set; }

        private readonly ISecurity m_UserSecurity;
        private readonly IDbLogger m_Log;

        public LoginModel(ISecurity security, IDbLogger logger)
        {
            m_UserSecurity = security;
            m_Log = logger;
        }

        public async Task<IActionResult> OnGetLogOff()
        {
            HttpContext.Session.Clear();
            await HttpContext.SignOutAsync();
            return Page();
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = m_UserSecurity.AuthenticateUserCredentials(UserLogin.LoginID, UserLogin.Password);

                    if (user != null)
                    {
                        var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.IsPersistent, "false", "bool"),
                        new Claim(ClaimTypes.Name, user.LoginId),
                        new Claim(ClaimTypes.GivenName, user.DisplayName),
                        new Claim("UserId", user.Id.ToString())
                    };

                        foreach (var role in user.AppUserRoles)
                        {
                            claims.Add(new Claim(ClaimTypes.Role, role.AppRole.Role));

                            if (claims.FirstOrDefault(x => x.Type == "Group") == null)
                            {
                                //if (role.AppRole.Role == BeratenHealthcareModels.Roles.Supervisor.ToString())
                                //    claims.Add(new Claim("Group", "Super"));
                            }
                        }

                        HttpContext.Session.SetInt32("UserAuthId", user.Id);

                        var claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme));
                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);

                        if (user.AppUserRoles.Count() != 0)
                        {
                            return RedirectToPage(Navigator.Dashboard);
                        }
                        else
                        {
                            HttpContext.Session.Clear();
                            //await HttpContext.SignOutAsync();
                            return RedirectToPage(Navigator.Login);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Invalid login attempt. Please try again.");
                        return Page();
                    }
                }
                else
                    return Page();
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}