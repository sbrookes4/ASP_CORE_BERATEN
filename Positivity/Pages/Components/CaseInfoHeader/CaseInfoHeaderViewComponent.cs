using BeratenHealthcareDataInterfaceLib;
using Microsoft.AspNetCore.Mvc;

namespace Positivity.Pages.Components
{
    public class CaseInfoHeaderViewComponent : ViewComponent
    {
        private readonly IIntake m_Intake;

        public CaseInfoHeaderViewComponent(IIntake intakeMngr)
        {
            m_Intake = intakeMngr;
        }

        public IViewComponentResult Invoke(int caseIntakeId)
        {
            var caseInfo = m_Intake.GetCaseIntakeInfo(caseIntakeId);
            return View(caseInfo);
        }
    }
}