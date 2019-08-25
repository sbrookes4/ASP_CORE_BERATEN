using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeratenHealthcareModels
{
    public class MentalHealthAssessment
    {
        public MentalHealthAssessment()
        {
            AppearanceArray = new List<string>();
            BodyTypeArray = new List<string>();
            EyeContactArray = new List<string>();
            HygieneArray = new List<string>();
            AttitudeArray = new List<string>();
            BodyMovementArray = new List<string>();
            BehaviorWithExaminersArray = new List<string>();
            BehaviorWithCareGiversArray = new List<string>();
            FacialExpressionArray = new List<string>();
            InterviewArray = new List<string>();
            FineMotorArray = new List<string>();
            GaitArray = new List<string>();
            GrossMotorArray = new List<string>();
            MascularArray = new List<string>();
            MotorBehaviorArray = new List<string>();
            ActivityLevelArray = new List<string>();
            AffectArray = new List<string>();
            AlertnessArray = new List<string>();
            AttentionArray = new List<string>();
            ConcentrationArray = new List<string>();
            FrustrationToleranceArray = new List<string>();
            IntellectualLevelArray = new List<string>();
            IntellectualFunctionArray = new List<string>();
            MoodArray = new List<string>();
            SelfSoothingCapacityArray = new List<string>();
            SensoryCognitionArray = new List<string>();
            SensoryIntegrationArray = new List<string>();
            TransitionsArray = new List<string>();
            AssociationsArray = new List<string>();
            DelusionsArray = new List<string>();
            HallucinationsArray = new List<string>();
            InsightArray = new List<string>();
            JudgementArray = new List<string>();
            MemoryArray = new List<string>();
            PhobiaArray = new List<string>();
            OrientationArray = new List<string>();
            FutureOrientArray = new List<string>();
            ThoughtContentArray = new List<string>();
            ThoughtProcessArray = new List<string>();
            ExpressiveLanguageArray = new List<string>();
            GeneralKnowledgeArray = new List<string>();
            ReceptiveLanguageArray = new List<string>();
            SpeechArray = new List<string>();
            EatingPatternsArray = new List<string>();
            SleepPatternsArray = new List<string>();
            UnusualBehaviorPatternArray = new List<string>();
            DegreeOfRiskArray = new List<string>();
            SelfHarmArray = new List<string>();
            OtherHarmArray = new List<string>();
            ImpulseControlArray = new List<string>();
            SuicideArray = new List<string>();
        }

        public int Id { get; set; }

        public int CaseIntakeId { get; set; }
        public virtual CaseIntake CaseIntake { get; set; }

        [Display(Name = "Assessment Date")]
        [DataType(DataType.Date, ErrorMessage = "Assessment Date is not a valid date")]
        [Required(ErrorMessage = "Assessment Date is required")]
        public DateTime AssessmentDate { get; set; }

        #region Mental Health

        #region General Appearance

        [StringLength(2000, ErrorMessage = "Appearance exceeded the max {1} characters")]
        public string Appearance { get; set; }

        [StringLength(2000, ErrorMessage = "Body Type exceeded the max {1} characters")]
        public string BodyType { get; set; }

        [StringLength(2000, ErrorMessage = "EyeContact exceeded the max {1} characters")]
        public string EyeContact { get; set; }

        [StringLength(2000, ErrorMessage = "Hygiene exceeded the max {1} characters")]
        public string Hygiene { get; set; }

        #endregion General Appearance

        #region Behavior

        [StringLength(2000, ErrorMessage = "Attitude exceeded the max {1} characters")]
        public string Attitude { get; set; }

        [StringLength(2000, ErrorMessage = "Body Movement exceeded the max {1} characters")]
        public string BodyMovement { get; set; }

        [StringLength(2000, ErrorMessage = "Behavior With Examiners exceeded the max {1} characters")]
        public string BehaviorWithExaminers { get; set; }

        [StringLength(2000, ErrorMessage = "Behavior With Care Givers exceeded the max {1} characters")]
        public string BehaviorWithCareGivers { get; set; }

        [StringLength(2000, ErrorMessage = "Facial Expression exceeded the max {1} characters")]
        public string FacialExpression { get; set; }

        [StringLength(2000, ErrorMessage = "Interview exceeded the max {1} characters")]
        public string Interview { get; set; }

        #endregion Behavior

        #region Motor

        [StringLength(2000, ErrorMessage = "Fine Motor exceeded the max {1} characters")]
        public string FineMotor { get; set; }

        [StringLength(2000, ErrorMessage = "Gait exceeded the max {1} characters")]
        public string Gait { get; set; }

        [StringLength(2000, ErrorMessage = "Gross Motor exceeded the max {1} characters")]
        public string GrossMotor { get; set; }

        [StringLength(2000, ErrorMessage = "Mascular exceeded the max {1} characters")]
        public string Mascular { get; set; }

        [StringLength(2000, ErrorMessage = "Motor Behavior exceeded the max {1} characters")]
        public string MotorBehavior { get; set; }

        #endregion Motor

        #region Regulation

        [StringLength(2000, ErrorMessage = "Activity Level exceeded the max {1} characters")]
        public string ActivityLevel { get; set; }

        [StringLength(2000, ErrorMessage = "Affect exceeded the max {1} characters")]
        public string Affect { get; set; }

        [StringLength(2000, ErrorMessage = "Alertness exceeded the max {1} characters")]
        public string Alertness { get; set; }

        [StringLength(2000, ErrorMessage = "Attention exceeded the max {1} characters")]
        public string Attention { get; set; }

        [StringLength(2000, ErrorMessage = "Concentration exceeded the max {1} characters")]
        public string Concentration { get; set; }

        [StringLength(2000, ErrorMessage = "Frustration Tolerance exceeded the max {1} characters")]
        public string FrustrationTolerance { get; set; }

        [StringLength(2000, ErrorMessage = "Intellectual Level exceeded the max {1} characters")]
        public string IntellectualLevel { get; set; }

        [StringLength(2000, ErrorMessage = "Intellectual Function exceeded the max {1} characters")]
        public string IntellectualFunction { get; set; }

        [StringLength(2000, ErrorMessage = "Mood exceeded the max {1} characters")]
        public string Mood { get; set; }

        [StringLength(2000, ErrorMessage = "Self Soothing Capacity exceeded the max {1} characters")]
        public string SelfSoothingCapacity { get; set; }

        [StringLength(2000, ErrorMessage = "Sensory Cognition exceeded the max {1} characters")]
        public string SensoryCognition { get; set; }

        [StringLength(2000, ErrorMessage = "Sensory Integration exceeded the max {1} characters")]
        public string SensoryIntegration { get; set; }

        [StringLength(2000, ErrorMessage = "Transitions exceeded the max {1} characters")]
        public string Transitions { get; set; }

        #endregion Regulation

        #region Cognition and Thought

        [StringLength(2000, ErrorMessage = "Associations exceeded the max {1} characters")]
        public string Associations { get; set; }

        [StringLength(2000, ErrorMessage = "Delusions exceeded the max {1} characters")]
        public string Delusions { get; set; }

        [StringLength(2000, ErrorMessage = "Hallucinations exceeded the max {1} characters")]
        public string Hallucinations { get; set; }

        [StringLength(2000, ErrorMessage = "Insight exceeded the max {1} characters")]
        public string Insight { get; set; }

        [StringLength(2000, ErrorMessage = "Judgement exceeded the max {1} characters")]
        public string Judgement { get; set; }

        [StringLength(2000, ErrorMessage = "Memory exceeded the max {1} characters")]
        public string Memory { get; set; }

        [StringLength(2000, ErrorMessage = "Phobia exceeded the max {1} characters")]
        public string Phobia { get; set; }

        [StringLength(2000, ErrorMessage = "Orientation exceeded the max {1} characters")]
        public string Orientation { get; set; }

        [StringLength(2000, ErrorMessage = "Future Orient exceeded the max {1} characters")]
        public string FutureOrient { get; set; }

        [StringLength(2000, ErrorMessage = "Thought Content exceeded the max {1} characters")]
        public string ThoughtContent { get; set; }

        [StringLength(2000, ErrorMessage = "Thought Process exceeded the max {1} characters")]
        public string ThoughtProcess { get; set; }

        #endregion Cognition and Thought

        #region Communication

        [StringLength(2000, ErrorMessage = "Expressive Language exceeded the max {1} characters")]
        public string ExpressiveLanguage { get; set; }

        [StringLength(2000, ErrorMessage = "General Knowledge exceeded the max {1} characters")]
        public string GeneralKnowledge { get; set; }

        [StringLength(2000, ErrorMessage = "Receptive Language exceeded the max {1} characters")]
        public string ReceptiveLanguage { get; set; }

        [StringLength(2000, ErrorMessage = "Speech exceeded the max {1} characters")]
        public string Speech { get; set; }

        #endregion Communication

        #region Patterns

        [StringLength(2000, ErrorMessage = "Eating Patterns exceeded the max {1} characters")]
        public string EatingPatterns { get; set; }

        [StringLength(2000, ErrorMessage = "Sleep Patterns exceeded the max {1} characters")]
        public string SleepPatterns { get; set; }

        [StringLength(2000, ErrorMessage = "Unusual Behavior Pattern exceeded the max {1} characters")]
        public string UnusualBehaviorPattern { get; set; }

        #endregion Patterns

        #region Risk

        [StringLength(2000, ErrorMessage = "Degree Of Risk exceeded the max {1} characters")]
        public string DegreeOfRisk { get; set; }

        [StringLength(2000, ErrorMessage = "Self Harm exceeded the max {1} characters")]
        public string SelfHarm { get; set; }

        [StringLength(2000, ErrorMessage = "Other Harm exceeded the max {1} characters")]
        public string OtherHarm { get; set; }

        [StringLength(2000, ErrorMessage = "Impulse Control exceeded the max {1} characters")]
        public string ImpulseControl { get; set; }

        [StringLength(2000, ErrorMessage = "Suicide exceeded the max {1} characters")]
        public string Suicide { get; set; }

        #endregion Risk

        [StringLength(2000, ErrorMessage = "Dsm Diagnosis exceeded the max {1} characters")]
        public string DsmDiagnosis { get; set; }

        #endregion Mental Health

        #region SignOff

        [StringLength(50)]
        public string AssessmentConducteddBy { get; set; }

        public byte[] ConductingClinicianSignature { get; set; }

        [Display(Name = "Clinitian Signed Date")]
        [DataType(DataType.Date, ErrorMessage = "Clinitian Signed Date is not a valid date")]
        public DateTime? DateClinitianSignedOn { get; set; }

        public bool IsCompleted { get; set; }

        [StringLength(50)]
        public string AssessmentCompletedBy { get; set; }

        public byte[] CompletingSupervisorSignature { get; set; }

        [Display(Name = "Supervisor Signed Date")]
        [DataType(DataType.Date, ErrorMessage = "Supervisor Signed Date is not a valid date")]
        public DateTime? DateSupervisorSignedOn { get; set; }

        #endregion SignOff

        [Required]
        [StringLength(50)]
        public string RecordedBy { get; set; }

        [Required]
        public DateTime RecordedOn { get; set; } = DateTime.Now;

        [NotMapped]
        public List<string> AppearanceArray { get; set; }

        [NotMapped]
        public List<string> BodyTypeArray { get; set; }

        [NotMapped]
        public List<string> EyeContactArray { get; set; }

        [NotMapped]
        public List<string> HygieneArray { get; set; }

        [NotMapped]
        public List<string> AttitudeArray { get; set; }

        [NotMapped]
        public List<string> BodyMovementArray { get; set; }

        [NotMapped]
        public List<string> BehaviorWithExaminersArray { get; set; }

        [NotMapped]
        public List<string> BehaviorWithCareGiversArray { get; set; }

        [NotMapped]
        public List<string> FacialExpressionArray { get; set; }

        [NotMapped]
        public List<string> InterviewArray { get; set; }

        [NotMapped]
        public List<string> FineMotorArray { get; set; }

        [NotMapped]
        public List<string> GaitArray { get; set; }

        [NotMapped]
        public List<string> GrossMotorArray { get; set; }

        [NotMapped]
        public List<string> MascularArray { get; set; }

        [NotMapped]
        public List<string> MotorBehaviorArray { get; set; }

        [NotMapped]
        public List<string> ActivityLevelArray { get; set; }

        [NotMapped]
        public List<string> AffectArray { get; set; }

        [NotMapped]
        public List<string> AlertnessArray { get; set; }

        [NotMapped]
        public List<string> AttentionArray { get; set; }

        [NotMapped]
        public List<string> ConcentrationArray { get; set; }

        [NotMapped]
        public List<string> FrustrationToleranceArray { get; set; }

        [NotMapped]
        public List<string> IntellectualLevelArray { get; set; }

        [NotMapped]
        public List<string> IntellectualFunctionArray { get; set; }

        [NotMapped]
        public List<string> MoodArray { get; set; }

        [NotMapped]
        public List<string> SelfSoothingCapacityArray { get; set; }

        [NotMapped]
        public List<string> SensoryCognitionArray { get; set; }

        [NotMapped]
        public List<string> SensoryIntegrationArray { get; set; }

        [NotMapped]
        public List<string> TransitionsArray { get; set; }

        [NotMapped]
        public List<string> AssociationsArray { get; set; }

        [NotMapped]
        public List<string> DelusionsArray { get; set; }

        [NotMapped]
        public List<string> HallucinationsArray { get; set; }

        [NotMapped]
        public List<string> InsightArray { get; set; }

        [NotMapped]
        public List<string> JudgementArray { get; set; }

        [NotMapped]
        public List<string> MemoryArray { get; set; }

        [NotMapped]
        public List<string> PhobiaArray { get; set; }

        [NotMapped]
        public List<string> OrientationArray { get; set; }

        [NotMapped]
        public List<string> FutureOrientArray { get; set; }

        [NotMapped]
        public List<string> ThoughtContentArray { get; set; }

        [NotMapped]
        public List<string> ThoughtProcessArray { get; set; }

        [NotMapped]
        public List<string> ExpressiveLanguageArray { get; set; }

        [NotMapped]
        public List<string> GeneralKnowledgeArray { get; set; }

        [NotMapped]
        public List<string> ReceptiveLanguageArray { get; set; }

        [NotMapped]
        public List<string> SpeechArray { get; set; }

        [NotMapped]
        public List<string> EatingPatternsArray { get; set; }

        [NotMapped]
        public List<string> SleepPatternsArray { get; set; }

        [NotMapped]
        public List<string> UnusualBehaviorPatternArray { get; set; }

        [NotMapped]
        public List<string> DegreeOfRiskArray { get; set; }

        [NotMapped]
        public List<string> SelfHarmArray { get; set; }

        [NotMapped]
        public List<string> OtherHarmArray { get; set; }

        [NotMapped]
        public List<string> ImpulseControlArray { get; set; }

        [NotMapped]
        public List<string> SuicideArray { get; set; }
    }
}