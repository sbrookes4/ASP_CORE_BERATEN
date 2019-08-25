using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Positivity.Pages.Case
{
    public class CaseDischargeModel : PageModel
    {
        private readonly IIntake m_CaseIntake;
        private readonly IDbLogger m_Log;

        public CaseDischargeModel(IIntake intakeMngr, IDbLogger logger)
        {
            m_CaseIntake = intakeMngr;
            m_Log = logger;
        }

        [BindProperty]
        public CaseDischarge CaseDischargeData { get; set; }

        public void OnGet(int caseIntakeId)
        {
            try
            {
                CaseDischargeData = m_CaseIntake.GetCaseDischarge(caseIntakeId);

                if (CaseDischargeData == null)
                {
                    CaseDischargeData = new CaseDischarge { CaseIntakeId = caseIntakeId };
                    CaseDischargeData.DischargeDate = TimeZoneUtility.DateTimeNow;
                    CaseDischargeData.DischargeTime = TimeZoneUtility.DateTimeNow;
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

                if (CaseDischargeData.DischargeDate > TimeZoneUtility.DateTimeNow)
                {
                    ModelState.AddModelError(string.Empty, "Case Discharge Date can't be a future date");
                    return Page();
                }

                if (CaseDischargeData.DischareReasonLookupId == 5 && (!CaseDischargeData.TransferredDate.HasValue || string.IsNullOrEmpty(CaseDischargeData.TransferredTo)))
                {
                    ModelState.AddModelError(string.Empty, "Transfer Date and Transfer to is requried");
                    return Page();
                }

                if (CaseDischargeData.DischargeTime.HasValue)
                {
                    CaseDischargeData.DischargeTime = CaseDischargeData.DischargeDate.Add(CaseDischargeData.DischargeTime.Value.TimeOfDay);
                }

                if (CaseDischargeData.Id > 0)
                {
                    m_CaseIntake.UpdateCaseDischarge(CaseDischargeData);
                }
                else
                {
                    m_CaseIntake.CreateCaseDischarge(CaseDischargeData);
                }

                return RedirectToPage(Navigator.UpdateCaseIntake, new { caseId = CaseDischargeData.CaseIntakeId });
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}