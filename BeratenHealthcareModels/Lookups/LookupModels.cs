using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeratenHealthcareModels
{
    public class BaseLookup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }
    }

    #region "Mental Health Assessment"

    [Table("AbuseLookup")]
    public class AbuseLookup : BaseLookup { }

    [Table("ActivityLevelLookup")]
    public class ActivityLevelLookup : BaseLookup { }

    [Table("AlertnessLookup")]
    public class AlertnessLookup : BaseLookup { }

    [Table("AffectLookup")]
    public class AffectLookup : BaseLookup { }

    [Table("AppearanceLookup")]
    public class AppearanceLookup : BaseLookup { }

    [Table("AttentionLookup")]
    public class AttentionLookup : BaseLookup { }

    [Table("AttitudeLookup")]
    public class AttitudeLookup : BaseLookup { }

    [Table("AssociationsLookup")]
    public class AssociationsLookup : BaseLookup { }

    [Table("BehaviorWithExaminersLookup")]
    public class BehaviorWithExaminersLookup : BaseLookup { }

    [Table("BehaviorWithCareGiversLookup")]
    public class BehaviorWithCareGiversLookup : BaseLookup { }

    [Table("BodyMovementLookup")]
    public class BodyMovementLookup : BaseLookup { }

    [Table("BodyTypeLookup")]
    public class BodyTypeLookup : BaseLookup { }

    [Table("ConcentrationLookup")]
    public class ConcentrationLookup : BaseLookup { }

    [Table("DegreeOfRiskLookup")]
    public class DegreeOfRiskLookup : BaseLookup { }

    [Table("DelusionsLookup")]
    public class DelusionsLookup : BaseLookup { }

    [Table("EatingPatternsLookup")]
    public class EatingPatternsLookup : BaseLookup { }

    [Table("EducationLookup")]
    public class EducationLookup : BaseLookup { }

    [Table("EligibilityLookup")]
    public class EligibilityLookup : BaseLookup { }

    [Table("EmploymentLookup")]
    public class EmploymentLookup : BaseLookup { }

    [Table("EnglishLanguageSkillsLookup")]
    public class EnglishLanguageSkillsLookup : BaseLookup { }

    [Table("RaceLookup")]
    public class RaceLookup : BaseLookup { }

    [Table("EthnicityHispanicLookup")]
    public class EthnicityHispanicLookup : BaseLookup { }

    [Table("ExpressiveLanguageLookup")]
    public class ExpressiveLanguageLookup : BaseLookup { }

    [Table("EyeContactLookup")]
    public class EyeContactLookup : BaseLookup { }

    [Table("FacialExpressionLookup")]
    public class FacialExpressionLookup : BaseLookup { }

    [Table("FamilyOriginLookup")]
    public class FamilyOriginLookup : BaseLookup { }

    [Table("FirstDispositionLookup")]
    public class FirstDispositionLookup : BaseLookup { }

    [Table("FrustrationToleranceLookup")]
    public class FrustrationToleranceLookup : BaseLookup { }

    [Table("FutureOrientLookup")]
    public class FutureOrientLookup : BaseLookup { }

    [Table("FineMotorLookup")]
    public class FineMotorLookup : BaseLookup { }

    [Table("GaitLookup")]
    public class GaitLookup : BaseLookup { }

    [Table("GenderLookup")]
    public class GenderLookup : BaseLookup { }

    [Table("GeneralKnowledgeLookup")]
    public class GeneralKnowledgeLookup : BaseLookup { }

    [Table("GrossMotorLookup")]
    public class GrossMotorLookup : BaseLookup { }

    [Table("HallucinationsLookup")]
    public class HallucinationsLookup : BaseLookup { }

    [Table("HygieneLookup")]
    public class HygieneLookup : BaseLookup { }

    //[Table("IdeaLookup")]
    //public  class IdeaLookup : BaseLookup { }

    [Table("ImpulseControlLookup")]
    public class ImpulseControlLookup : BaseLookup { }

    [Table("IncomeSourceLookup")]
    public class IncomeSourceLookup : BaseLookup { }

    [Table("IntakeMethodLookup")]
    public class IntakeMethodLookup : BaseLookup { }

    [Table("InsightLookup")]
    public class InsightLookup : BaseLookup { }

    [Table("IntellectualFunctionLookup")]
    public class IntellectualFunctionLookup : BaseLookup { }

    [Table("IntellectualLevelLookup")]
    public class IntellectualLevelLookup : BaseLookup { }

    [Table("InterviewLookup")]
    public class InterviewLookup : BaseLookup { }

    [Table("JudgementLookup")]
    public class JudgementLookup : BaseLookup { }

    //[Table("LegalStatusLookup")]
    //public  class LegalStatusLookup : BaseLookup { }

    [Table("LivingArrangementLookup")]
    public class LivingArrangementLookup : BaseLookup { }

    [Table("MaritalStatusLookup")]
    public class MaritalStatusLookup : BaseLookup { }

    [Table("MascularLookup")]
    public class MascularLookup : BaseLookup { }

    [Table("MemoryLookup")]
    public class MemoryLookup : BaseLookup { }

    [Table("MoodLookup")]
    public class MoodLookup : BaseLookup { }

    [Table("MotorBehaviorLookup")]
    public class MotorBehaviorLookup : BaseLookup { }

    [Table("OrientationLookup")]
    public class OrientationLookup : BaseLookup { }

    [Table("OtherHarmLookup")]
    public class OtherHarmLookup : BaseLookup { }

    [Table("PhobiaLookup")]
    public class PhobiaLookup : BaseLookup { }

    [Table("PreferredLanguageLookup")]
    public class PreferredLanguageLookup : BaseLookup { }

    [Table("ProblemDomainLookup")]
    public class ProblemDomainLookup : BaseLookup { }

    [Table("ProgramsLookup")]
    public class ProgramsLookup : BaseLookup { }

    [Table("ReferralSourceLookup")]
    public class ReferralSourceLookup : BaseLookup { }

    [Table("DischareReasonLookup")]
    public class DischareReasonLookup : BaseLookup { }

    [Table("RelationshipTypeLookup")]
    public class RelationshipTypeLookup : BaseLookup { }

    [Table("ReceptiveLanguageLookup")]
    public class ReceptiveLanguageLookup : BaseLookup { }

    //[Table("ReliabilityLookup")]
    //public  class ReliabilityLookup : BaseLookup { }

    [Table("ResidenceLookup")]
    public class ResidenceLookup : BaseLookup { }

    [Table("SchoolsLookup")]
    public class SchoolsLookup : BaseLookup { }

    [Table("SelfHarmLookup")]
    public class SelfHarmLookup : BaseLookup { }

    [Table("SelfSoothingCapacityLookup")]
    public class SelfSoothingCapacityLookup : BaseLookup { }

    [Table("SensoryCognitionLookup")]
    public class SensoryCognitionLookup : BaseLookup { }

    [Table("SensoryIntegrationLookup")]
    public class SensoryIntegrationLookup : BaseLookup { }

    [Table("SpecialNeedsLookup")]
    public class SpecialNeedsLookup : BaseLookup { }

    [Table("SpeechLookup")]
    public class SpeechLookup : BaseLookup { }

    [Table("SuicideLookup")]
    public class SuicideLookup : BaseLookup { }

    [Table("SleepPatternsLookup")]
    public class SleepPatternsLookup : BaseLookup { }

    [Table("StateLookup")]
    public class StateLookup : BaseLookup { }

    [Table("ThoughtContentLookup")]
    public class ThoughtContentLookup : BaseLookup { }

    [Table("ThoughtProcessLookup")]
    public class ThoughtProcessLookup : BaseLookup { }

    [Table("TransitionsLookup")]
    public class TransitionsLookup : BaseLookup { }

    [Table("UnusualBehaviorPatternsLookup")]
    public class UnusualBehaviorPatternsLookup : BaseLookup { }

    [Table("UrgencyLevelLookup")]
    public class UrgencyLevelLookup : BaseLookup { }

    //[Table("UserTypesLookup")]
    //public class UserTypesLookup : BaseLookup { }

    #endregion "Mental Health Assessment"

    [Table("TreatmentModalityLookup")]
    public class TreatmentModalityLookup : BaseLookup { }

    [Table("ServiceLocationLookup")]
    public class ServiceLocationLookup : BaseLookup { }

    [Table("AppointmentStatusLookup")]
    public class AppointmentStatusLookup : BaseLookup { }

    [Table("ContactMethodLookup")]
    public class ContactMethodLookup : BaseLookup { }

    [Table("PresentingProblemsLookup")]
    public class PresentingProblemsLookup : BaseLookup { }

    //[Table("InterventionFrequencyLookup")]
    //public class InterventionFrequencyLookup : BaseLookup { }

    //[Table("InterventionDurationLookup")]
    //public class InterventionDurationLookup : BaseLookup { }
}