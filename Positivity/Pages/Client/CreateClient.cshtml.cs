using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Positivity.Pages.Client
{
    [Authorize]
    public class CreateClientModel : PageModel
    {
        private readonly IClient m_Client;
        private readonly IDbLogger m_Log;

        public CreateClientModel(IClient ClientMngr, IDbLogger logger)
        {
            m_Client = ClientMngr;
            m_Log = logger;
        }

        [BindProperty]
        public BeratenHealthcareModels.Client ClientData { get; set; }

        public void OnGet()
        {
            ClientData = new BeratenHealthcareModels.Client();
        }

        public IActionResult OnPost()
        {
            try
            {
                if (ModelState.IsValid != true)
                {
                    return Page();
                }

                m_Client.CreateClient(ClientData);

                return RedirectToPage(Navigator.ClientDetails, new { clientId = ClientData.Id });
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}