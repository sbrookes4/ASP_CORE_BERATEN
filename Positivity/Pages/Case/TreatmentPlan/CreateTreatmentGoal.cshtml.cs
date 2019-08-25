using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Linq;

namespace Positivity.Pages.Case.TreatmentPlan
{
    [Authorize]
    public class CreateTreatmentGoalModel : PageModel
    {
        private readonly ITreatmentPlan m_TreatmentPlan;
        private readonly IDbLogger m_Log;

        public CreateTreatmentGoalModel(ITreatmentPlan treatmentPlanMngr, IDbLogger logger)
        {
            m_TreatmentPlan = treatmentPlanMngr;
            m_Log = logger;
        }

        [BindProperty]
        public TreatmentGoal TreatmentGoalData { get; set; }

        public int CaseIntakeId { get; set; }

        public void OnGet(int treatmentPlanId, int caseIntakeId)
        {
            try
            {
                CaseIntakeId = caseIntakeId;

                TreatmentGoalData = new BeratenHealthcareModels.TreatmentGoal { TreatmentPlanId = treatmentPlanId , TargetDate = TimeZoneUtility.DateTimeNow};
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

                if (TreatmentGoalData.ModalitiesArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    TreatmentGoalData.Modalities = string.Join("@", TreatmentGoalData.ModalitiesArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                m_TreatmentPlan.CreateTreatmentGoal(TreatmentGoalData);

                return RedirectToPage(Navigator.UpdateTreatmentPlan, new { treatmentPlanId = TreatmentGoalData.TreatmentPlanId });
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}