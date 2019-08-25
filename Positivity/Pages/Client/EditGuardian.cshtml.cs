
using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Linq;

namespace Positivity.Pages.Client
{
    public class EditGuardianModel : PageModel
    {
        private readonly IClient m_Client;
        private readonly IDbLogger m_Log;

        public EditGuardianModel(IClient clientMngr, IDbLogger logger)
        {
            m_Client = clientMngr;
            m_Log = logger;
        }

        [BindProperty]
        public BeratenHealthcareModels.Guardian GuardianData { get; set; }


        public void OnGet(int clientId)
        {
            try
            {
                GuardianData = m_Client.GetClientGuardian(clientId);
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }

        }

        public IActionResult OnPost()
        {
            try
            {
                if (ModelState.IsValid != true)
                {
                    return Page();
                }

                m_Client.UpdateClientGuardian(GuardianData);

                return RedirectToPage(Navigator.ClientDetails, new { clientId = GuardianData.ClientId });
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}

