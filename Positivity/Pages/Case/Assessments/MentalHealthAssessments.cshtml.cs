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
    public class MentalHealthAssessmentsModel : PageModel
    {
        private readonly IAssessment m_Assessment;
        private readonly IDbLogger m_Log;

        public MentalHealthAssessmentsModel(IAssessment assessmentMngr, IDbLogger logger)
        {
            m_Assessment = assessmentMngr;
            m_Log = logger;
        }

        [BindProperty]
        public IList<MentalHealthAssessment> MentalHealthAssessmentList { get; set; }

        public int CaseIntakeId { get; set; }

        public void OnGet(int caseIntakeId)
        {
            try
            {
                CaseIntakeId = caseIntakeId;
                MentalHealthAssessmentList = m_Assessment.GetAllMentalHealthAssessments(caseIntakeId);
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}