using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BeratenHealthcareDataAccessLib
{
    public class TreatmentPlanManager : BaseManager, ITreatmentPlan
    {
        public TreatmentPlan GetTreatmentPlan(int treatmentPlanId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return dbModel.TreatmentPlans.Find(treatmentPlanId);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public int CreateTreatmentPlan(TreatmentPlan treatmentPlan)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    dbModel.TreatmentPlans.Add(treatmentPlan);
                    dbModel.SaveChanges();
                    return treatmentPlan.Id;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public bool UpdateTreatmentPlan(TreatmentPlan treatmentPlanData)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    var entity = dbModel.TreatmentPlans.Find(treatmentPlanData.Id);

                    if (entity == null)
                        return false;

                    dbModel.Entry<TreatmentPlan>(entity).CurrentValues.SetValues(treatmentPlanData);
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

        public TreatmentGoal GetTreatmentGoal(int goalId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return dbModel.TreatmentGoals.Find(goalId);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public int CreateTreatmentGoal(TreatmentGoal goalData)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    dbModel.TreatmentGoals.Add(goalData);
                    dbModel.SaveChanges();

                    return goalData.Id;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public bool UpdateTreatmentGoal(TreatmentGoal goalData)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    var entity = dbModel.TreatmentGoals.Find(goalData.Id);

                    if (entity == null)
                        return false;

                    dbModel.Entry<TreatmentGoal>(entity).CurrentValues.SetValues(goalData);
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

        public IList<TreatmentPlan> GetAllTreatmentPlans(int caseIntakeId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return dbModel.TreatmentPlans.Where(x => x.CaseIntakeId == caseIntakeId).OrderByDescending(x => x.Id).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public IList<TreatmentGoal> GetAllTreatmentGoals(int treatmentPlanId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return dbModel.TreatmentGoals.Where(x => x.TreatmentPlanId == treatmentPlanId).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public IList<BaseLookup> GetAllStaff()
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
                            where R.Id != (int)Roles.Admin && R.Id != (int)Roles.SuperAdmin
                            select new BaseLookup
                            {
                                Id = U.Id,
                                Description = U.DisplayName,
                            }).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public IList<GoalDTO> GetAllTreatmentGoalForCase(int caseIntakeId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    var goals = (from g in dbModel.TreatmentGoals
                                 join cp in dbModel.TreatmentPlans on g.TreatmentPlanId equals cp.Id
                                 where (cp.CaseIntakeId == caseIntakeId)
                                 orderby g.Id descending
                                 select new GoalDTO
                                 {
                                     Id = g.Id,
                                     Goal = g.Goal,
                                     Modalities = g.Modalities.Replace("@", " , ")
                                 }
                                 ).ToList();
                    return goals;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        // What is this?
        //public IList<TreatmentPlan> GetTreatmentPlans(TreatmentPlanSearchCriteria searchCriteria)
        //{
        //    var clientId = searchCriteria.ClientId;

        //    try
        //    {
        //        return GetEntityCollectionByClause<TreatmentPlan>(x =>
        //        (clientId == null || x.ClientId == clientId.Value)
        //        );
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        //public int CreateGoalObjective( GoalObjective objectiveData )
        //{
        //    try
        //    {
        //        using (var dbModel = InitiateDbContext())
        //        {
        //            dbModel.GoalObjectives.Add( objectiveData );
        //            dbModel.SaveChanges();

        //            return objectiveData.Id;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine( ex.ToString() );
        //        throw;
        //    }
        //}

        //public bool UpdateGoalObjective( GoalObjective objectiveData )
        //{
        //    try
        //    {
        //        using (var dbModel = InitiateDbContext())
        //        {
        //            var entity = dbModel.GoalObjectives.Find( objectiveData.Id );

        //            if (entity == null)
        //                return false;

        //            dbModel.Entry<GoalObjective>( entity ).CurrentValues.SetValues( objectiveData );
        //            dbModel.SaveChanges();

        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine( ex.ToString() );
        //        throw;
        //    }
        //}

        //public GoalObjective GetGoalObjective( int objectiveId )
        //{
        //    try
        //    {
        //        using (var dbModel = InitiateDbContext())
        //        {
        //            return dbModel.GoalObjectives.Find( objectiveId );
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine( ex.ToString() );
        //        throw;
        //    }
        //}
    }
}