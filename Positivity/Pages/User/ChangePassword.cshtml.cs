using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Positivity.Pages.User
{
    [Authorize]
    public class ChangePasswordModel : PageModel
    {
        private readonly ISecurity m_Security;
        private readonly IDbLogger m_Log;

        public ChangePasswordModel(ISecurity securityMngr, IDbLogger logger)
        {
            m_Security = securityMngr;
            m_Log = logger;
        }

        public void OnGet()
        {
        }

        [BindProperty]
        public Positivity.Models.ChangePasswordModel ChangePasswordModelData { get; set; }

        public IActionResult OnPost()
        {
            try
            {
                if (ModelState.IsValid != true)
                {
                    return Page();
                }

                bool Ischanged = m_Security.ChangePassword(ChangePasswordModelData.LoginID, ChangePasswordModelData.Password, ChangePasswordModelData.NewPassword);

                if (Ischanged)
                {
                    return RedirectToPage(Navigator.Dashboard);
                }
                else
                {
                    ModelState.AddModelError(" ", "Your Current Login ID & Password Do Not Match.  Please Try Again");
                    return Page();
                }
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}