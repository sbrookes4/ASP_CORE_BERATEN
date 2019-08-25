using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Positivity.Pages.User
{
    [Authorize]
    public class DashboardModel : PageModel
    {
        private readonly IDashboard m_Dashboard;
        private readonly IDbLogger m_Log;

        public DashboardModel(IDashboard dashboardMngr, IDbLogger logger)
        {
            m_Dashboard = dashboardMngr;
            m_Log = logger;
        }

        public IList<Widget> UserWidgetsList { get; set; }

        public void OnGet()
        {
            try
            {
                int userId = int.Parse(User.Claims.FirstOrDefault(s => s.Type == "UserId").Value);
                UserWidgetsList = m_Dashboard.GetMyWidgets(userId);
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}