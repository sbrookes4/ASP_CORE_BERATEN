using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Linq;

namespace Positivity.Pages.Client
{
    public class EditCoverageModel : PageModel
    {
        private readonly IClient m_Client;
        private readonly IDbLogger m_Log;

        public EditCoverageModel(IClient clientMngr, IDbLogger logger)
        {
            m_Client = clientMngr;
            m_Log = logger;
        }

        [BindProperty]
        public BeratenHealthcareModels.Coverage CoverageData { get; set; }


        public void OnGet(int clientId)
        {
            try
            {
                CoverageData = m_Client.GetClientCoverage(clientId);
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

                m_Client.UpdateClientCoverage(CoverageData);

                return RedirectToPage(Navigator.ClientDetails, new { clientId = CoverageData.ClientId });
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}

