using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace Positivity.Pages.Search
{
    public class ClientSearchModel : PageModel
    {
        private readonly IClient m_Client;
        private readonly IDbLogger m_Log;

        public ClientSearchModel(IClient clientMngr, IDbLogger logger)
        {
            m_Client = clientMngr;
            m_Log = logger;
        }

        [BindProperty]
        public ClientSearchCriteria SearchData { get; set; }

        public IList<ClientDTO> ClientList { get; set; }

        public IActionResult OnPost()
        {
            try
            {
                ClientList = m_Client.SearchClients(SearchData);
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