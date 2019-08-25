using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Positivity.Pages.User.Components
{
    public class AllOpenCasesWidgetViewComponent : ViewComponent
    {
        private readonly IDashboard m_Dashboard;

        public AllOpenCasesWidgetViewComponent(IDashboard dashboard)
        {
            m_Dashboard = dashboard;
        }

        public IViewComponentResult Invoke()
        {
            IList<CaseIntakeDTO> list = m_Dashboard.GetAllOpenCases();
            return View(list);
        }
    }
}