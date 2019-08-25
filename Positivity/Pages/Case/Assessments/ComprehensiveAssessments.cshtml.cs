using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace Positivity.Pages.Case.Assessments
{
    [Authorize]
    public class ComprehensiveAssessmentsModel : PageModel
    {
        private readonly IAssessment m_Assessment;
        private readonly IDbLogger m_Log;

        public ComprehensiveAssessmentsModel(IAssessment assessmentMngr, IDbLogger logger)
        {
            m_Assessment = assessmentMngr;
            m_Log = logger;
        }

        [BindProperty]
        public IList<ComprehensiveAssessment> ComprehensiveAssessmentList { get; set; }

        public int CaseIntakeId { get; set; }

        public void OnGet(int caseIntakeId)
        {
            try
            {
                CaseIntakeId = caseIntakeId;
                ComprehensiveAssessmentList = m_Assessment.GetAllComprehensiveAssessments(caseIntakeId);
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}