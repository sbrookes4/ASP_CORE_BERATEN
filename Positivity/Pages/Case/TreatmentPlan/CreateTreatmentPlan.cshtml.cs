using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Linq;

namespace Positivity.Pages.Case.TreatmentPlan
{
    [Authorize]
    public class CreateTreatmentPlanModel : PageModel
    {
        private readonly ITreatmentPlan m_TreatmentPlan;
        private readonly IDbLogger m_Log;

        public CreateTreatmentPlanModel(ITreatmentPlan treatmentPlanMngr, IDbLogger logger)
        {
            m_TreatmentPlan = treatmentPlanMngr;
            m_Log = logger;
        }

        [BindProperty]
        public BeratenHealthcareModels.TreatmentPlan TreatmentPlanData { get; set; }

        public void OnGet(int caseIntakeId)
        {
            try
            {
                TreatmentPlanData = new BeratenHealthcareModels.TreatmentPlan { CaseIntakeId = caseIntakeId, PlanDate = TimeZoneUtility.DateTimeNow, PlanTime = TimeZoneUtility.DateTimeNow };
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

                if (TreatmentPlanData.PlanDate > TimeZoneUtility.DateTimeNow)
                {
                    ModelState.AddModelError(string.Empty, "Plan Date can't be a future date");
                    return Page();
                }

                if (TreatmentPlanData.AttendingStaffArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    TreatmentPlanData.AttendingStaffNames = string.Join("@", TreatmentPlanData.AttendingStaffArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                if (TreatmentPlanData.PlanTime.HasValue)
                {
                    TreatmentPlanData.PlanTime = TreatmentPlanData.PlanDate.Date.Add(TreatmentPlanData.PlanTime.Value.TimeOfDay);
                }

                m_TreatmentPlan.CreateTreatmentPlan(TreatmentPlanData);

                return RedirectToPage(Navigator.TreatmentPlans, new { caseIntakeId = TreatmentPlanData.CaseIntakeId });
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}