using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Positivity.Pages.Case.Assessments
{
    [Authorize]
    public class AssessmentsModel : PageModel
    {
        private readonly IDbLogger m_Log;

        public AssessmentsModel(IDbLogger logger)
        {
            m_Log = logger;
        }

        public int CaseIntakeId { get; set; }

        public void OnGet(int caseIntakeId)
        {
            try
            {
                CaseIntakeId = caseIntakeId;
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}