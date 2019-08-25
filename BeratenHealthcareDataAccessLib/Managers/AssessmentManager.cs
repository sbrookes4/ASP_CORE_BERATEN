using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BeratenHealthcareDataAccessLib
{
    public class AssessmentManager : BaseManager, IAssessment
    {
        public IList<ComprehensiveAssessment> GetAllComprehensiveAssessments(int caseIntakeId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return (from A in dbModel.ComprehensiveAssessments
                            where (A.CaseIntakeId == caseIntakeId)
                            orderby A.Id descending
                            select A
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public ComprehensiveAssessment GetComprehensiveAssessment(int comprehensiveAssessmentId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return dbModel.ComprehensiveAssessments.Find(comprehensiveAssessmentId);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public int CreateComprehensiveAssessment(ComprehensiveAssessment comprehensiveAssessment)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    dbModel.ComprehensiveAssessments.Add(comprehensiveAssessment);
                    dbModel.SaveChanges();
                    return comprehensiveAssessment.Id;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public bool UpdateComprehensiveAssessment(ComprehensiveAssessment comprehensiveAssessmentData)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    var entity = dbModel.ComprehensiveAssessments.Find(comprehensiveAssessmentData.Id);

                    if (entity == null)
                        return false;

                    dbModel.Entry<ComprehensiveAssessment>(entity).CurrentValues.SetValues(comprehensiveAssessmentData);
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

        public IList<MentalHealthAssessment> GetAllMentalHealthAssessments(int caseIntakeId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return (from A in dbModel.MentalHealthAssessments
                            where (A.CaseIntakeId == caseIntakeId)
                            orderby A.Id descending
                            select A
                        ).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public MentalHealthAssessment GetMentalHealthAssessment(int mentalHealthAssessmentId)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    return dbModel.MentalHealthAssessments.Find(mentalHealthAssessmentId);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public int CreateMentalHealthAssessment(MentalHealthAssessment mentalHealthAssessment)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    dbModel.MentalHealthAssessments.Add(mentalHealthAssessment);
                    dbModel.SaveChanges();
                    return mentalHealthAssessment.Id;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        public bool UpdateMentalHealthAssessment(MentalHealthAssessment mentalHealthAssessmentData)
        {
            try
            {
                using (var dbModel = InitiateDbContext())
                {
                    var entity = dbModel.MentalHealthAssessments.Find(mentalHealthAssessmentData.Id);

                    if (entity == null)
                        return false;

                    dbModel.Entry<MentalHealthAssessment>(entity).CurrentValues.SetValues(mentalHealthAssessmentData);
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
    }
}