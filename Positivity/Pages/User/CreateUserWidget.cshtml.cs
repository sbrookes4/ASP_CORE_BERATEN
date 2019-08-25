using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace Positivity.Pages.User
{
    [Authorize]
    public class CreateUserWidgetModel : PageModel
    {
        private readonly IIntake m_CaseIntake;
        private readonly IDashboard m_Dashboard;
        private readonly IDbLogger m_Log;

        public CreateUserWidgetModel(IIntake intakeMngr, IDashboard dashboardMngr, IDbLogger logger)
        {
            m_CaseIntake = intakeMngr;
            m_Dashboard = dashboardMngr;
            m_Log = logger;
        }

        public IList<Widget> UserWidgetsList { get; set; }

        [BindProperty]
        public Widget WidgetData { get; set; }

        public void OnGet(int appUserId)
        {
            try
            {
                UserWidgetsList = m_Dashboard.GetMyWidgets(appUserId);

                WidgetData = new Widget { UserId = appUserId };
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

                //if (
                //        widget.WidgetComponentId == WidgetComponents

                //   )
                //{
                //    widget.IsMyStuff = true;
                //}

                m_Dashboard.CreateWidget(WidgetData);
                return RedirectToPage(Navigator.CreateUserWidget, new { userId = WidgetData.UserId });
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }

        public IActionResult OnGetRemove(int id, int userId)
        {
            try
            {
                m_Dashboard.RemoveWidget(id);

                return RedirectToPage(Navigator.CreateUserWidget, new { userId = userId });
            }
            catch (Exception ex)
            {
                m_Log.CriticalEntry(User.Identity.Name, ex.ToString());
                throw;
            }
        }
    }
}