using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace Positivity.Pages.Search
{
    public class CaseSearchModel : PageModel
    {
        private readonly IIntake m_Intake;
        private readonly IDbLogger m_Log;

        public CaseSearchModel(IIntake intakeMngr, IDbLogger logger)
        {
            m_Intake = intakeMngr;
            m_Log = logger;
        }

        [BindProperty]
        public CaseSearchCriteria SearchData { get; set; }

        public IList<CaseIntakeDTO> CaseList { get; set; }

        public IActionResult OnPost()
        {
            try
            {
                CaseList = m_Intake.SearchCases(SearchData);
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