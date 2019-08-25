using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Positivity.Pages.Case.Assessments
{
    [Authorize]
    public class CreateComprehensiveAssessmentModel : PageModel
    {
        private readonly IAssessment m_Assessment;
        private readonly IDbLogger m_Log;

        public CreateComprehensiveAssessmentModel(IAssessment assessmentMngr, IDbLogger logger)
        {
            m_Assessment = assessmentMngr;
            m_Log = logger;
        }

        [BindProperty]
        public BeratenHealthcareModels.ComprehensiveAssessment ComprehensiveAssessmentData { get; set; }

        public void OnGet(int caseIntakeId)
        {
            try
            {
                ComprehensiveAssessmentData = new BeratenHealthcareModels.ComprehensiveAssessment { CaseIntakeId = caseIntakeId, AssessmentDate = TimeZoneUtility.DateTimeNow };
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

                m_Assessment.CreateComprehensiveAssessment(ComprehensiveAssessmentData);

                return RedirectToPage(Navigator.ComprehensiveAssessmentList, new { caseIntakeId = ComprehensiveAssessmentData.CaseIntakeId });
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}