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
    public class CreateCaseIntakeModel : PageModel
    {
        private readonly IIntake m_CaseIntake;
        private readonly IDbLogger m_Log;

        public CreateCaseIntakeModel(IIntake intakeMngr, IDbLogger logger)
        {
            m_CaseIntake = intakeMngr;
            m_Log = logger;
        }

        [BindProperty]
        public CaseIntake CaseIntakeData { get; set; }

        public void OnGet(int clientId)
        {
            try
            {
                CaseIntakeData = new CaseIntake { ClientId = clientId, IntakeTime = TimeZoneUtility.DateTimeNow, IntakeDate = TimeZoneUtility.DateTimeNow };
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

                if (CaseIntakeData.PresentingProblemsArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    CaseIntakeData.PresentingProblems = string.Join("@", CaseIntakeData.PresentingProblemsArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                CaseIntakeData.IntakeTime = CaseIntakeData.IntakeDate.Date.Add(CaseIntakeData.IntakeTime.TimeOfDay);

                m_CaseIntake.CreateCaseIntake(CaseIntakeData);

                return RedirectToPage(Navigator.ClientDetails, new { clientId = CaseIntakeData.ClientId });
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}