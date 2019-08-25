using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Positivity.Pages.User
{
    public class ResetPasswordModel : PageModel
    {
            private readonly ISecurity m_Security;
            private readonly IDbLogger m_Log;

            public ResetPasswordModel(ISecurity securityMngr, IDbLogger logger)
            {
                m_Security = securityMngr;
                m_Log = logger;
            }

            [BindProperty]
            public AppUser AppUserData { get; set; }

            public void OnGet(int appUserId)
            {
                AppUserData = m_Security.GetAppUser(appUserId);
            }

            public IActionResult OnPost(AppUser appUserData)
            {
                try
                {

                bool Ischanged = m_Security.ResetPassword(appUserData.LoginId, appUserData.Password);

                return RedirectToPage(Navigator.CreateAppUser);
            }
                catch (Exception ex)
                {
                    m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                    throw;
                }
            }
        }
    }