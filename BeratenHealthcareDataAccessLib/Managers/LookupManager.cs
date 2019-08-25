using BeratenHealthcareDataInterfaceLib;
using BeratenHealthcareModels;
using System.Collections.Generic;

namespace BeratenHealthcareDataAccessLib
{
    public class LookupManager : BaseManager, ILookup
    {
        public IList<EthnicityHispanicLookup> GetEthnicityList()
        {
            return GetLookupCollection<EthnicityHispanicLookup>();
        }

        public IList<IntakeMethodLookup> GetIntakeMethodList()
        {
            return GetLookupCollection<IntakeMethodLookup>();
        }

        public IList<StateLookup> GetStateList()
        {
            return GetLookupCollection<StateLookup>();
        }

        public IList<GenderLookup> GetGenderList()
        {
            return GetLookupCollection<GenderLookup>();
        }

        public IList<RaceLookup> GetRaceList()
        {
            return GetLookupCollection<RaceLookup>();
        }

        public IList<MaritalStatusLookup> GetMaritalStatusList()
        {
            return GetLookupCollection<MaritalStatusLookup>();
        }

        public IList<AbuseLookup> GetAbuseList()
        {
            return GetLookupCollection<AbuseLookup>();
        }

        public IList<AffectLookup> GetAffectList()
        {
            return GetLookupCollection<AffectLookup>();
        }

        public IList<AppearanceLookup> GetAppearanceList()
        {
            return GetLookupCollection<AppearanceLookup>();
        }

        public IList<HygieneLookup> GetHygieneList()
        {
            return GetLookupCollection<HygieneLookup>();
        }

        public IList<BodyMovementLookup> GetBodyMovementList()
        {
            return GetLookupCollection<BodyMovementLookup>();
        }

        public IList<BodyTypeLookup> GetBodyTypeList()
        {
            return GetLookupCollection<BodyTypeLookup>();
        }

        public IList<EyeContactLookup> GetEyeContactList()
        {
            return GetLookupCollection<EyeContactLookup>();
        }

        public IList<FineMotorLookup> GetFineMotorList()
        {
            return GetLookupCollection<FineMotorLookup>();
        }

        public IList<GrossMotorLookup> GetGrossMotorList()
        {
            return GetLookupCollection<GrossMotorLookup>();
        }

        public IList<MascularLookup> GetMascularList()
        {
            return GetLookupCollection<MascularLookup>();
        }

        public IList<GaitLookup> GetGaitList()
        {
            return GetLookupCollection<GaitLookup>();
        }

        public IList<FacialExpressionLookup> GetFacialExpressionList()
        {
            return GetLookupCollection<FacialExpressionLookup>();
        }

        public IList<MoodLookup> GetMoodList()
        {
            return GetLookupCollection<MoodLookup>();
        }

        public IList<SpeechLookup> GetSpeechList()
        {
            return GetLookupCollection<SpeechLookup>();
        }

        public IList<AttitudeLookup> GetAttiduteList()
        {
            return GetLookupCollection<AttitudeLookup>();
        }

        public IList<ThoughtContentLookup> GetThoughtContentList()
        {
            return GetLookupCollection<ThoughtContentLookup>();
        }

        public IList<PhobiaLookup> GetPhobiaList()
        {
            return GetLookupCollection<PhobiaLookup>();
        }

        public IList<DelusionsLookup> GetDelusionsList()
        {
            return GetLookupCollection<DelusionsLookup>();
        }

        public IList<HallucinationsLookup> GetHallucinationsList()
        {
            return GetLookupCollection<HallucinationsLookup>();
        }

        public IList<AssociationsLookup> GetAssociationsList()
        {
            return GetLookupCollection<AssociationsLookup>();
        }

        public IList<ThoughtProcessLookup> GetThoughtProcessList()
        {
            return GetLookupCollection<ThoughtProcessLookup>();
        }

        public IList<AttentionLookup> GetAttentionList()
        {
            return GetLookupCollection<AttentionLookup>();
        }

        public IList<ConcentrationLookup> GetConcentrationList()
        {
            return GetLookupCollection<ConcentrationLookup>();
        }

        public IList<OrientationLookup> GetOrientationList()
        {
            return GetLookupCollection<OrientationLookup>();
        }

        public IList<IntellectualLevelLookup> GetIntellectualLevelList()
        {
            return GetLookupCollection<IntellectualLevelLookup>();
        }

        public IList<MemoryLookup> GetMemoryList()
        {
            return GetLookupCollection<MemoryLookup>();
        }

        //public IList<ReliabilityLookup> GetReliabilityList()
        //{
        //    return GetLookupCollection<ReliabilityLookup>();
        //}

        public IList<ImpulseControlLookup> GetImpulseControlList()
        {
            return GetLookupCollection<ImpulseControlLookup>();
        }

        public IList<JudgementLookup> GetJudgementList()
        {
            return GetLookupCollection<JudgementLookup>();
        }

        public IList<InsightLookup> GetInsightList()
        {
            return GetLookupCollection<InsightLookup>();
        }

        public IList<ProgramsLookup> GetProgramsList()
        {
            return GetLookupCollection<ProgramsLookup>();
        }

        public IList<InterviewLookup> GetInterviewList()
        {
            return GetLookupCollection<InterviewLookup>();
        }

        public IList<ProblemDomainLookup> GetProblemDomainsList()
        {
            return GetLookupCollection<ProblemDomainLookup>();
        }

        public IList<AppointmentStatusLookup> GetAppointmentStatusList()
        {
            return GetLookupCollection<AppointmentStatusLookup>();
        }

        public IList<ServiceLocationLookup> GetServiceLocationsList()
        {
            return GetLookupCollection<ServiceLocationLookup>();
        }

        public IList<SuicideLookup> GetSuicideList()
        {
            return GetLookupCollection<SuicideLookup>();
        }

        public IList<SelfHarmLookup> GetSelfHarmList()
        {
            return GetLookupCollection<SelfHarmLookup>();
        }

        public IList<OtherHarmLookup> GetOtherHarmList()
        {
            return GetLookupCollection<OtherHarmLookup>();
        }

        public IList<DegreeOfRiskLookup> GetDegreeOfRiskList()
        {
            return GetLookupCollection<DegreeOfRiskLookup>();
        }

        public IList<SensoryCognitionLookup> GetSensoryCognitionList()
        {
            return GetLookupCollection<SensoryCognitionLookup>();
        }

        public IList<FutureOrientLookup> GetFutureOrientList()
        {
            return GetLookupCollection<FutureOrientLookup>();
        }

        public IList<GeneralKnowledgeLookup> GetGeneralKnowledgeList()
        {
            return GetLookupCollection<GeneralKnowledgeLookup>();
        }

        public IList<SpecialNeedsLookup> GetSpecialNeedsList()
        {
            return GetLookupCollection<SpecialNeedsLookup>();
        }

        public IList<PreferredLanguageLookup> GetPreferredLanguageList()
        {
            return GetLookupCollection<PreferredLanguageLookup>();
        }

        public IList<ResidenceLookup> GetResidenceList()
        {
            return GetLookupCollection<ResidenceLookup>();
        }

        public IList<IncomeSourceLookup> GetIncomeSourceList()
        {
            return GetLookupCollection<IncomeSourceLookup>();
        }

        public IList<RelationshipTypeLookup> GetRelationshipTypeList()
        {
            return GetLookupCollection<RelationshipTypeLookup>();
        }

        public IList<ActivityLevelLookup> GetActivityLevelList()
        {
            return GetLookupCollection<ActivityLevelLookup>();
        }

        public IList<SelfSoothingCapacityLookup> GetSelfSoothingCapacityList()
        {
            return GetLookupCollection<SelfSoothingCapacityLookup>();
        }

        public IList<SensoryIntegrationLookup> GetSensoryIntegrationList()
        {
            return GetLookupCollection<SensoryIntegrationLookup>();
        }

        public IList<AlertnessLookup> GetAlertnessList()
        {
            return GetLookupCollection<AlertnessLookup>();
        }

        public IList<TransitionsLookup> GetTransitionsList()
        {
            return GetLookupCollection<TransitionsLookup>();
        }

        public IList<FrustrationToleranceLookup> GetFrustrationToleranceList()
        {
            return GetLookupCollection<FrustrationToleranceLookup>();
        }

        public IList<SleepPatternsLookup> GetSleepPatternsList()
        {
            return GetLookupCollection<SleepPatternsLookup>();
        }

        public IList<EatingPatternsLookup> GetEatingPatternsList()
        {
            return GetLookupCollection<EatingPatternsLookup>();
        }

        public IList<UnusualBehaviorPatternsLookup> GetUnusualBehaviorPatternsList()
        {
            return GetLookupCollection<UnusualBehaviorPatternsLookup>();
        }

        public IList<BehaviorWithCareGiversLookup> GetBehaviorWithCareGiversList()
        {
            return GetLookupCollection<BehaviorWithCareGiversLookup>();
        }

        public IList<BehaviorWithExaminersLookup> GetBehaviorWithExaminersList()
        {
            return GetLookupCollection<BehaviorWithExaminersLookup>();
        }

        public IList<ReceptiveLanguageLookup> GetReceptiveLanguageList()
        {
            return GetLookupCollection<ReceptiveLanguageLookup>();
        }

        public IList<ExpressiveLanguageLookup> GetExpressiveLanguageList()
        {
            return GetLookupCollection<ExpressiveLanguageLookup>();
        }

        public IList<TreatmentModalityLookup> GetTreatmentModalityList()
        {
            return GetLookupCollection<TreatmentModalityLookup>();
        }

        public IList<ReferralSourceLookup> GetReferralSourceList()
        {
            return GetLookupCollection<ReferralSourceLookup>();
        }

        public IList<UrgencyLevelLookup> GetUngencyLevlList()
        {
            return GetLookupCollection<UrgencyLevelLookup>();
        }

        public IList<PresentingProblemsLookup> GetPresentingProblemsList()
        {
            return GetLookupCollection<PresentingProblemsLookup>();
        }

        public IList<FirstDispositionLookup> GetFirstDispositionList()
        {
            return GetLookupCollection<FirstDispositionLookup>();
        }

        public IList<ContactMethodLookup> GetContactMethodList()
        {
            return GetLookupCollection<ContactMethodLookup>();
        }

        public IList<MotorBehaviorLookup> GetMotorBehaviorList()
        {
            return GetLookupCollection<MotorBehaviorLookup>();
        }

        public IList<IntellectualFunctionLookup> GetIntellectualFunctionList()
        {
            return GetLookupCollection<IntellectualFunctionLookup>();
        }

        public IList<EducationLookup> GetEducationList()
        {
            return GetLookupCollection<EducationLookup>();
        }

        public IList<EmploymentLookup> GetEmploymentList()
        {
            return GetLookupCollection<EmploymentLookup>();
        }

        public IList<DischareReasonLookup> GetDischareReasonList()
        {
            return GetLookupCollection<DischareReasonLookup>();
        }
    }
}