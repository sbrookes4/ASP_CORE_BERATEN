using BeratenHealthcareModels;
using System.Collections.Generic;

namespace BeratenHealthcareDataInterfaceLib
{
    public interface ILookup
    {
        IList<AbuseLookup> GetAbuseList();

        IList<IntakeMethodLookup> GetIntakeMethodList();

        IList<AppearanceLookup> GetAppearanceList();

        IList<HygieneLookup> GetHygieneList();

        IList<BodyMovementLookup> GetBodyMovementList();

        IList<BodyTypeLookup> GetBodyTypeList();

        IList<EyeContactLookup> GetEyeContactList();

        IList<FineMotorLookup> GetFineMotorList();

        IList<GrossMotorLookup> GetGrossMotorList();

        IList<MascularLookup> GetMascularList();

        IList<GaitLookup> GetGaitList();

        IList<AttentionLookup> GetAttentionList();

        IList<MoodLookup> GetMoodList();

        IList<AffectLookup> GetAffectList();

        IList<ActivityLevelLookup> GetActivityLevelList();

        IList<SelfSoothingCapacityLookup> GetSelfSoothingCapacityList();

        IList<SensoryIntegrationLookup> GetSensoryIntegrationList();

        IList<AlertnessLookup> GetAlertnessList();

        IList<TransitionsLookup> GetTransitionsList();

        IList<FrustrationToleranceLookup> GetFrustrationToleranceList();

        IList<FacialExpressionLookup> GetFacialExpressionList();

        IList<SpeechLookup> GetSpeechList();

        IList<AttitudeLookup> GetAttiduteList();

        IList<ThoughtContentLookup> GetThoughtContentList();

        IList<PhobiaLookup> GetPhobiaList();

        IList<DelusionsLookup> GetDelusionsList();

        IList<HallucinationsLookup> GetHallucinationsList();

        IList<ThoughtProcessLookup> GetThoughtProcessList();

        IList<AssociationsLookup> GetAssociationsList();

        IList<ConcentrationLookup> GetConcentrationList();

        IList<OrientationLookup> GetOrientationList();

        IList<IntellectualLevelLookup> GetIntellectualLevelList();

        IList<MemoryLookup> GetMemoryList();

        IList<ImpulseControlLookup> GetImpulseControlList();

        IList<JudgementLookup> GetJudgementList();

        IList<InsightLookup> GetInsightList();

        IList<InterviewLookup> GetInterviewList();

        IList<SuicideLookup> GetSuicideList();

        IList<SelfHarmLookup> GetSelfHarmList();

        IList<OtherHarmLookup> GetOtherHarmList();

        IList<DegreeOfRiskLookup> GetDegreeOfRiskList();

        IList<SensoryCognitionLookup> GetSensoryCognitionList();

        IList<FutureOrientLookup> GetFutureOrientList();

        IList<GeneralKnowledgeLookup> GetGeneralKnowledgeList();

        IList<EthnicityHispanicLookup> GetEthnicityList();

        IList<GenderLookup> GetGenderList();

        IList<RaceLookup> GetRaceList();

        IList<StateLookup> GetStateList();

        IList<MaritalStatusLookup> GetMaritalStatusList();

        IList<SpecialNeedsLookup> GetSpecialNeedsList();

        IList<PreferredLanguageLookup> GetPreferredLanguageList();

        IList<ResidenceLookup> GetResidenceList();

        IList<IncomeSourceLookup> GetIncomeSourceList();

        IList<RelationshipTypeLookup> GetRelationshipTypeList();

        IList<ProgramsLookup> GetProgramsList();

        IList<ProblemDomainLookup> GetProblemDomainsList();

        IList<AppointmentStatusLookup> GetAppointmentStatusList();

        IList<ServiceLocationLookup> GetServiceLocationsList();

        IList<SleepPatternsLookup> GetSleepPatternsList();

        IList<EatingPatternsLookup> GetEatingPatternsList();

        IList<UnusualBehaviorPatternsLookup> GetUnusualBehaviorPatternsList();

        IList<BehaviorWithCareGiversLookup> GetBehaviorWithCareGiversList();

        IList<BehaviorWithExaminersLookup> GetBehaviorWithExaminersList();

        IList<ReceptiveLanguageLookup> GetReceptiveLanguageList();

        IList<ExpressiveLanguageLookup> GetExpressiveLanguageList();

        IList<TreatmentModalityLookup> GetTreatmentModalityList();

        IList<ReferralSourceLookup> GetReferralSourceList();

        IList<UrgencyLevelLookup> GetUngencyLevlList();

        IList<PresentingProblemsLookup> GetPresentingProblemsList();

        IList<FirstDispositionLookup> GetFirstDispositionList();

        IList<ContactMethodLookup> GetContactMethodList();

        IList<MotorBehaviorLookup> GetMotorBehaviorList();

        IList<IntellectualFunctionLookup> GetIntellectualFunctionList();

        IList<EducationLookup> GetEducationList();

        IList<EmploymentLookup> GetEmploymentList();

        IList<DischareReasonLookup> GetDischareReasonList();
    }
}