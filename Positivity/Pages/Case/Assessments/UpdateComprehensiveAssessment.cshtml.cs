using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Positivity.Pages.Case.Assessments
{
    [Authorize]
    public class UpdateComprehensiveAssessmentModel : PageModel
    {
        private readonly IAssessment m_Assessment;
        private readonly IDbLogger m_Log;

        public UpdateComprehensiveAssessmentModel(IAssessment assessmentMngr, IDbLogger logger)
        {
            m_Assessment = assessmentMngr;
            m_Log = logger;
        }

        [BindProperty]
        public BeratenHealthcareModels.ComprehensiveAssessment ComprehensiveAssessmentData { get; set; }

        public void OnGet(int AssessmentId)
        {
            try
            {
                ComprehensiveAssessmentData = m_Assessment.GetComprehensiveAssessment(AssessmentId);
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

                m_Assessment.UpdateComprehensiveAssessment(ComprehensiveAssessmentData);
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