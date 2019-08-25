using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BeratenHealthcareDataAccessLib
{
    public class IntakeManager : BaseManager, IIntake
    {
        #region Case Intake

        public CaseIntake GetCaseIntake(int caseId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return dbModel.CaseIntakes.Find(caseId);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public int CreateCaseIntake(CaseIntake caseData)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    caseData.CaseNumber = Utility.GetNextNumber(dbModel, "GetNextCaseNumber");

                    dbModel.CaseIntakes.Add(caseData);
                    dbModel.SaveChanges();

                    return caseData.Id;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public bool UpdateCaseIntake(CaseIntake caseData)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    var entity = dbModel.CaseIntakes.Find(caseData.Id);

                    if (entity == null)
                        return false;

                    dbModel.Entry<CaseIntake>(entity).CurrentValues.SetValues(caseData);
                    dbModel.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public IList<AppUser> GetCaseTeam(int caseId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return (from U in dbModel.AppUsers
                            join UR in dbModel.AppUserRoles
                            on U.Id equals UR.AppUserId
                            join R in dbModel.AppRoles
                            on UR.AppRoleId equals R.Id
                            where R.Id != (int)Roles.SuperAdmin && R.Id != (int)Roles.Admin
                            select U
                    ).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString()); throw;
            }
        }

        public CaseIntakeDTO GetCaseIntakeInfo(int caseIntakeId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return (from C in dbModel.CaseIntakes
                            join CL in dbModel.Clients on C.ClientId equals CL.Id
                            join d in dbModel.CaseDischarges on C.Id equals d.CaseIntakeId into temp
                            from D in temp.DefaultIfEmpty()
                            where C.Id == caseIntakeId
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
                                ClientMRNumber = CL.MedicalRecordNumber,
                                ClientName = CL.DisplayName,
                                ClientDOB = CL.DateOfBirthFormatted,
                                ClientAddress = CL.DisplayAddress,
                            }

                        ).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        #endregion Case Intake

        #region Case Discharge

        public CaseDischarge GetCaseDischarge(int caseId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return dbModel.CaseDischarges.Where(x => x.CaseIntakeId == caseId).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public int CreateCaseDischarge(CaseDischarge caseDischargeData)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    dbModel.CaseDischarges.Add(caseDischargeData);
                    dbModel.SaveChanges();

                    return caseDischargeData.Id;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public bool UpdateCaseDischarge(CaseDischarge caseDischargeData)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    var entity = dbModel.CaseDischarges.Find(caseDischargeData.Id);

                    if (entity == null)
                        return false;

                    dbModel.Entry<CaseDischarge>(entity).CurrentValues.SetValues(caseDischargeData);
                    dbModel.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        #endregion Case Discharge

        #region Case Intake Search

        public IList<CaseIntakeDTO> SearchCases(CaseSearchCriteria sc)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    IList<CaseIntake> cases = null;

                    if (sc.CaseNumber == null && sc.CaseDate == null && sc.CaseName == null && sc.ToCaseDate == null)
                    {
                        cases = dbModel.CaseIntakes.Include(x => x.Client).Take(10).ToList();
                    }
                    else
                    {
                        var q = dbModel.CaseIntakes.OrderByDescending(x => x.Id).AsQueryable(); ;

                        if (!string.IsNullOrEmpty(sc.CaseNumber))
                        {
                            q = q.Where(x => (x.CaseNumber + "").ToLower().StartsWith((sc.CaseNumber + "").ToLower()) || sc.CaseNumber == null);
                        }

                        if (!string.IsNullOrEmpty(sc.CaseName))
                        {
                            q = q.Where(x => sc.CaseName == null || (x.CaseName + "").ToLower().Contains((sc.CaseName + "").ToLower()));
                        }

                        if (sc.CaseDate != null && sc.ToCaseDate == null)
                        {
                            q = q.Where(x => sc.CaseDate == null || DateTime.Equals(x.IntakeDate, sc.CaseDate));
                        }

                        if (sc.CaseDate != null && sc.ToCaseDate != null)
                        {
                            q = q.Where(x => x.IntakeDate >= sc.CaseDate && x.IntakeDate <= sc.ToCaseDate);
                        }

                        if (sc.CaseDate == null && sc.ToCaseDate != null)
                        {
                            q = q.Where(x => x.IntakeDate <= sc.ToCaseDate);
                        }

                        cases = q.Include(x => x.Client).ToList();
                    }
                    return (from C in cases
                            orderby C.Id descending
                            select new CaseIntakeDTO
                            {
                                Id = C.Id,
                                CaseNumber = C.CaseNumber,
                                CaseName = C.CaseName,
                                IntakeDate = C.IntakeDate,
                                IntakeTime = C.IntakeTime,
                                PresentingProblems = C.PresentingProblems,
                                ClientId = C.ClientId,
                                ClientMRNumber = C.Client.MedicalRecordNumber,
                                ClientName = C.Client.DisplayName,
                            }).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        #endregion Case Intake Search
    }
}