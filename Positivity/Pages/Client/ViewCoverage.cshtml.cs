using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Positivity.Pages.Client
{
    public class ViewCoverageModel : PageModel
    {

        private readonly IClient m_Client;
        private readonly IDbLogger m_Log;

        public BeratenHealthcareModels.Client ViewCoverageData { get; set; }


        public void OnGet()
        {

        }
    }
}