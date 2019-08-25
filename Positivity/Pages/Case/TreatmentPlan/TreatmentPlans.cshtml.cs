using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace Positivity.Pages.Case.TreatmentPlan
{
    [Authorize]
    public class TreatmentPlansModel : PageModel
    {
        private readonly ITreatmentPlan m_TreatmentPlan;
        private readonly IDbLogger m_Log;

        public TreatmentPlansModel(ITreatmentPlan treatmentPlanMngr, IDbLogger logger)
        {
            m_TreatmentPlan = treatmentPlanMngr;
            m_Log = logger;
        }

        [BindProperty]
        public IList<BeratenHealthcareModels.TreatmentPlan> TreatmentPlanList { get; set; }

        public int CaseIntakeId { get; set; }

        public void OnGet(int caseIntakeId)
        {
            try
            {
                CaseIntakeId = caseIntakeId;
                TreatmentPlanList = m_TreatmentPlan.GetAllTreatmentPlans(caseIntakeId);
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}