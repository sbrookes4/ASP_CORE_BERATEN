using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace Positivity.Pages.Case.TreatmentPlan
{
    [Authorize]
    public class ViewTreatmentPlanModel : PageModel
    {
        private readonly ITreatmentPlan m_TreatmentPlan;
        private readonly IDbLogger m_Log;

        public BeratenHealthcareModels.TreatmentPlan TreatmentPlanData { get; set; }
        public IList<BeratenHealthcareModels.TreatmentGoal> TreatmentGoalList { get; set; }

        public ViewTreatmentPlanModel(ITreatmentPlan treatmentPlanMngr, IDbLogger logger)
        {
            m_TreatmentPlan = treatmentPlanMngr;
            m_Log = logger;
        }

        public void OnGet(int treatmentPlanId)
        {
            try
            {
                TreatmentGoalList = m_TreatmentPlan.GetAllTreatmentGoals(treatmentPlanId);
                TreatmentPlanData = m_TreatmentPlan.GetTreatmentPlan(treatmentPlanId);

                //if (TreatmentPlanData.AttendingStaffNames != null)
                //{
                //    TreatmentPlanData.AttendingStaffArray = TreatmentPlanData.AttendingStaffNames.Split("@").ToList();
                //}
            }
            catch (Exception ex)

            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}