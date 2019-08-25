//using BeratenHealthcareDataInterfaceLib;
//using BeratenHealthcareModels;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;

//namespace BeratenHealthcareDataAccessLib
//{
//    internal class AssessmentManager : BaseManager, IAssessment
//    {

//        public Assessment GetAssessmentData( int assessmentId )
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    return dbModel.Assessments
//                        .Include( i => i.DiagnosisDsm5Code )
//                        .Include( i => i.DiagnosisDsm5Code1 )
//                        .Include( i => i.DiagnosisDsm5Code2 )
//                        .Include( i => i.DiagnosisDsm5Code3 )
//                        .Include( i => i.LivingArrangementLookup )
//                        .Include( i => i.MentalHealthNotes )
//                        .FirstOrDefault( a => a.Id == assessmentId );
//                }
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public Assessment GetClientAssessmentData( int clientId )
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    return GetEntityByClause<Assessment>( a => a.ClientId == clientId && a.IsCaseClosed != true,
//                    a => a.AssessmentByClinician, a => a.ReferralSourceLookup, a => a.FirstActivityLookup, a => a.UrgencyLevelLookup );
//                }
//                //using (var context = InitiateDbContext())
//                //{
//                //    return context.Assessments
//                //        .Include(i => i.ReferralSourceLookup)
//                //        .Include(i => i.FirstActivityLookup)
//                //        .Include(i => i.UrgencyLevelLookup)
//                //        .Include(i => i.AssessmentByClinician)                                                
//                //        .FirstOrDefault(a => a.ClientId == clientId && a.IsCaseClosed != true);
//                //}
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public IList<Assessment> GetAssessments( AssessmentSearchCriteria assessmentSearch )
//        {
//            try
//            {
//                var firstName = assessmentSearch.FirstName + "";
//                var lastName = assessmentSearch.LastName + "";
//                var dtStart = assessmentSearch.DateStart;
//                var dtEnd = assessmentSearch.DateEnd;
//                var clientId = assessmentSearch.ClientId;

//                using (var dbModel = InitiateDbContext())
//                {
//                    return
//                    GetEntityCollectionByClause<Assessment>(
//                        x =>
//                            x.Client.FirstName.ToLower().StartsWith( firstName.ToLower() )
//                            && x.Client.LastName.ToLower().StartsWith( lastName.ToLower() )
//                            && (dtStart == null || x.DateAssessmentStarted >= dtStart.Value)
//                            && (dtEnd == null || x.DateAssessmentStarted <= dtEnd.Value)
//                            && (clientId == null || x.ClientId == clientId.Value)
//                        );
//                }

//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public IList<Assessment> GetAssessmentsByClient( int clientId )
//        {
//            using (var dbModel = InitiateDbContext())
//            {
//                return GetEntityCollectionByClause<Assessment>( ia => ia.ClientId == clientId );
//            }
//        }

//        public int CreateAssessment( Assessment assessment )
//        {
//            try
//            {
//                Create<Assessment>( assessment );
//                return assessment.Id;
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }

//        public bool UpdateAssessment( Assessment assessment )
//        {
//            try
//            {
//                using (var dbModel = InitiateDbContext())
//                {
//                    if (assessment.MentalHealthNotes != null)
//                    {
//                        if (assessment.MentalHealthNotes.Id == 0)
//                        {
//                            Create<MentalHealthNotes>( assessment.MentalHealthNotes );
//                            assessment.MentalHealthNotesId = assessment.MentalHealthNotes.Id;
//                        }
//                        else
//                            Update<MentalHealthNotes>( assessment.MentalHealthNotes, assessment.MentalHealthNotes.Id );
//                    }

//                    return Update<Assessment>( assessment, assessment.Id );
//                }
//            }
//            catch (Exception ex)
//            {
//                return false;
//            }
//        }
//    }
//}
