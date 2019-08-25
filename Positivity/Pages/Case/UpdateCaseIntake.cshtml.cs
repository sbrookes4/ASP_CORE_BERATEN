using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Linq;

namespace Positivity.Pages.Case
{
    [Authorize]
    public class UpdateCaseIntakeModel : PageModel
    {
        private readonly IIntake m_CaseIntake;
        private readonly IDbLogger m_Log;

        public UpdateCaseIntakeModel(IIntake intakeMngr, IDbLogger logger)
        {
            m_CaseIntake = intakeMngr;
            m_Log = logger;
        }

        [BindProperty]
        public CaseIntake CaseIntakeData { get; set; }

        public void OnGet(int caseIntakeId)
        {
            try
            {
                CaseIntakeData = m_CaseIntake.GetCaseIntake(caseIntakeId);

                if (CaseIntakeData.PresentingProblems != null)
                {
                    CaseIntakeData.PresentingProblemsArray = CaseIntakeData.PresentingProblems.Split("@").ToList();
                }
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

                if (CaseIntakeData.IntakeDate > TimeZoneUtility.DateTimeNow)
                {
                    ModelState.AddModelError(string.Empty, "Intake Date can't be a future date");
                    return Page();
                }

                CaseIntakeData.IntakeTime = CaseIntakeData.IntakeDate.Date.Add(CaseIntakeData.IntakeTime.TimeOfDay);

                if (CaseIntakeData.PresentingProblemsArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    CaseIntakeData.PresentingProblems = string.Join("@", CaseIntakeData.PresentingProblemsArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                m_CaseIntake.UpdateCaseIntake(CaseIntakeData);
                return RedirectToPage(Navigator.UpdateCaseIntake, new { referralId = CaseIntakeData.Id });
            }
            catch (Exception ex)

            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}