using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Positivity.Pages.User
{
    [Authorize]
    public class CreateAppUserModel : PageModel
    {
        private readonly ISecurity m_Security;
        private readonly IDbLogger m_Log;

        public CreateAppUserModel(ISecurity securityMngr, IDbLogger logger)
        {
            m_Security = securityMngr;
            m_Log = logger;
        }

        [BindProperty]
        public AppUser AppUserData { get; set; }

        public IList<AppUser> AppUsersList { get; set; }

        public IList<AppRole> AppRolesList { get; set; }

        public void OnGet()
        {
            AppUsersList = m_Security.GetAllAppUsers();

            AppRolesList = m_Security.GetAllAppRoles();

            AppUserData = new AppUser();
        }


        public IActionResult OnPost(AppUser appUserData, [FromForm] IFormCollection coll)
        {
            try
            {
                if (ModelState.IsValid != true)
                {
                    return Page();
                }

                int roleId = int.Parse(coll.Where(x => x.Key == "AppRoleId").Select(x => x.Value).FirstOrDefault());

                m_Security.CreateAppUser(AppUserData, roleId);

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