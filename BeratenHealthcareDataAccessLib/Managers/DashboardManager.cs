using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BeratenHealthcareDataAccessLib
{
    public class DashboardManager : BaseManager, IDashboard
    {
        public IList<Widget> GetMyWidgets(int userId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return dbModel.Widgets.Where(x => x.UserId == userId)
                       .OrderBy(x => x.WidgetOrder).AsNoTracking().ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public void RemoveWidget(int id)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    Widget entity = dbModel.Widgets.Find(id);
                    dbModel.Widgets.Remove(entity);
                    dbModel.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public int CreateWidget(Widget widget)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    dbModel.Widgets.Add(widget);
                    dbModel.SaveChanges();
                    return widget.Id;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public IList<CaseIntakeDTO> GetAllOpenCases()
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return (from C in dbModel.CaseIntakes
                            join CL in dbModel.Clients on C.ClientId equals CL.Id
                            join d in dbModel.CaseDischarges on C.Id equals d.CaseIntakeId into temp
                            from D in temp.DefaultIfEmpty()
                            where D == null || D.DischargeDate == null
                            select new CaseIntakeDTO
                            {
                                Id = C.Id,

                                CaseNumber = C.CaseNumber,
                                CaseName = C.CaseName,
                                IntakeDate = C.IntakeDate,
                                IntakeTime = C.IntakeTime,
                                IntakeMethod = C.IntakeMethodLookup.Description,
                                PresentingProblems = C.PresentingProblems,
                                ClientId = CL.Id,

                                ClientName = CL.DisplayName,
                            }

                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}