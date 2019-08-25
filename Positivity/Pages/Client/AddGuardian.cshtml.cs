
using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Positivity.Pages.Client
{
    public class AddGuardianModel : PageModel
    {
        private readonly IClient m_Client;
        private readonly IDbLogger m_Log;

        public AddGuardianModel(IClient clientMngr, IDbLogger logger)
        {
            m_Client = clientMngr;
            m_Log = logger;
        }

        [BindProperty]
        public BeratenHealthcareModels.Guardian GuardianData { get; set; }


        public void OnGet()
        {
            try
            {
                GuardianData = new BeratenHealthcareModels.Guardian();
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


                m_Client.CreateClientGuardian(GuardianData);

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

