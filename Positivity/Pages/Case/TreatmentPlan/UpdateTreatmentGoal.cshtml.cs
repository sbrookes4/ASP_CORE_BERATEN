using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Linq;

namespace Positivity.Pages.Case.TreatmentPlan
{
    [Authorize]
    public class UpdateTreatmentGoalModel : PageModel
    {
        private readonly ITreatmentPlan m_TreatmentPlan;
        private readonly IDbLogger m_Log;

        public UpdateTreatmentGoalModel(ITreatmentPlan treatmentPlanMngr, IDbLogger logger)
        {
            m_TreatmentPlan = treatmentPlanMngr;
            m_Log = logger;
        }

        [BindProperty]
        public BeratenHealthcareModels.TreatmentGoal TreatmentGoalData { get; set; }

        public int CaseIntakeId { get; set; }

        public void OnGet(int treatmentGoalId, int caseIntakeId)
        {
            try
            {
                CaseIntakeId = caseIntakeId;

                TreatmentGoalData = m_TreatmentPlan.GetTreatmentGoal(treatmentGoalId);

                if (TreatmentGoalData.Modalities != null)
                {
                    TreatmentGoalData.ModalitiesArray = TreatmentGoalData.Modalities.Split("@").ToList();
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

                if (TreatmentGoalData.ModalitiesArray.Where(x => !string.IsNullOrEmpty(x)).Count() > 0)
                {
                    TreatmentGoalData.Modalities = string.Join("@", TreatmentGoalData.ModalitiesArray.Where(x => !string.IsNullOrEmpty(x)).ToArray());
                }

                m_TreatmentPlan.UpdateTreatmentGoal(TreatmentGoalData);
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