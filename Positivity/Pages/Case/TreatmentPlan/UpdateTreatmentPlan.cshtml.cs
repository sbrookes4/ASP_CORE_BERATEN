using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Positivity.Pages.Case.TreatmentPlan
{
    [Authorize]
    public class UpdateTreatmentPlanModel : PageModel
    {
        private readonly ITreatmentPlan m_TreatmentPlan;
        private readonly IDbLogger m_Log;

        public UpdateTreatmentPlanModel(ITreatmentPlan treatmentPlanMngr, IDbLogger logger)
        {
            m_TreatmentPlan = treatmentPlanMngr;
            m_Log = logger;
        }

        [BindProperty]
        public BeratenHealthcareModels.TreatmentPlan TreatmentPlanData { get; set; }

        public IList<BeratenHealthcareModels.TreatmentGoal> TreatmentGoalList { get; set; }

        public void OnGet(int treatmentPlanId)
        {
            try
            {
                TreatmentGoalList = m_TreatmentPlan.GetAllTreatmentGoals(treatmentPlanId);
                TreatmentPlanData = m_TreatmentPlan.GetTreatmentPlan(treatmentPlanId);

                if (TreatmentPlanData.AttendingStaffNames != null)
                {
                    TreatmentPlanData.AttendingStaffArray = TreatmentPlanData.AttendingStaffNames.Split("@").ToList();
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

                if (TreatmentPlanData.PlanDate > TimeZoneUtility.DateTimeNow)
                {
                    ModelState.AddModelError(string.Empty, "Plan Date can't be a future date");
                    return Page();
                }

                if (TreatmentPlanData.PlanTime.HasValue)
                {
                    TreatmentPlanData.PlanTime = TreatmentPlanData.PlanDate.Date.Add(TreatmentPlanData.PlanTime.Value.TimeOfDay);
                }

                if (TreatmentPlanData.AttendingStaffArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    TreatmentPlanData.AttendingStaffNames = string.Join("@", TreatmentPlanData.AttendingStaffArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                m_TreatmentPlan.UpdateTreatmentPlan(TreatmentPlanData);
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