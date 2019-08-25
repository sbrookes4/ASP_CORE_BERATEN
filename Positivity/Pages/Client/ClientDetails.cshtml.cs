using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Positivity.Pages.Client
{
    [Authorize]
    public class ClientDetailsModel : PageModel
    {
        private readonly IClient m_Client;
        private readonly IDbLogger m_Log;

        public ClientDetailsModel(IClient clientMngr, IDbLogger logger)
        {
            m_Client = clientMngr;
            m_Log = logger;
        }

        [BindProperty]
        public BeratenHealthcareModels.Client ClientData { get; set; }

        public void OnGet(int clientId)
        {
            try
            {
                ClientData = m_Client.GetClientWithDetails(clientId);
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}