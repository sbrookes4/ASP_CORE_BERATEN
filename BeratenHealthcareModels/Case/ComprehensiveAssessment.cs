using System;
using System.ComponentModel.DataAnnotations;

namespace BeratenHealthcareModels
{
    public class ComprehensiveAssessment
    {
        public int Id { get; set; }

        public int CaseIntakeId { get; set; }
        public virtual CaseIntake CaseIntake { get; set; }

        [Display(Name = "Assessment Date")]
        [DataType(DataType.Date, ErrorMessage = "Assessment Date is not a valid date")]
        [Required(ErrorMessage = "Assessment Date is required")]
        public DateTime AssessmentDate { get; set; }

        [Display(Name = " EducationL")]
        public int? EducationLookupId { get; set; }

        public EducationLookup EducationLookup { get; set; }

        #region Employment

        [Display(Name = " Employment")]
        public int? EmploymentLookupId { get; set; }

        public EmploymentLookup EmploymentLookup { get; set; }

        [StringLength(2000, ErrorMessage = "Employment History exceeded the max {1} characters")]
        public string EmploymentHistory { get; set; }

        [StringLength(2000, ErrorMessage = "Relationship With Management Description exceeded the max {1} characters")]
        public string RelationshipWithManagementDesc { get; set; }

        [StringLength(2000, ErrorMessage = "Relationship With Peers Description exceeded the max {1} characters")]
        public string RelationshipWithPeersDesc { get; set; }

        [StringLength(2000, ErrorMessage = "Social Relationship Description exceeded the max {1} characters")]
        public string SocialRelationshipDesc { get; set; }

        [StringLength(2000, ErrorMessage = "Community Involvment Description exceeded the max {1} characters")]
        public string CommunityInvolvmentDesc { get; set; }

        #endregion Employment

        #region School Related Tab

        [StringLength(100, ErrorMessage = "School exceeded the max {1} characters")]
        public string School { get; set; }

        [StringLength(100, ErrorMessage = "School Teacher exceeded the max {1} characters")]
        public string SchoolTeacher { get; set; }

        [Range(0, 99)]
        public int? SchoolGrade { get; set; }

        [Range(0, 99)]
        public decimal? SchoolGPA { get; set; }

        [StringLength(2000, ErrorMessage = "Relationship With Staff Description exceeded the max {1} characters")]
        public string RelationshipWithStaffDesc { get; set; }

        [StringLength(2000, ErrorMessage = "Relationship With Classmates Description exceeded the max {1} characters")]
        public string RelationshipWithClassmatesDesc { get; set; }

        [StringLength(2000, ErrorMessage = "School Attendance And Additional Notes Description exceeded the max {1} characters")]
        public string SchoolAttendanceAndAdditionalNotesDesc { get; set; }

        [StringLength(2000, ErrorMessage = "School Educational And Vocational Goals Description exceeded the max {1} characters")]
        public string SchoolEducationalAndVocationalGoalsDesc { get; set; }

        [StringLength(2000, ErrorMessage = "School Special Needs Description exceeded the max {1} characters")]
        public string SchoolSpecialNeedsDesc { get; set; }

        #endregion School Related Tab

        #region Historical Data Tab

        [StringLength(2000, ErrorMessage = "Historical Substance Abuse Data exceeded the max {1} characters")]
        public string HistoricalSubstanceAbuseData { get; set; }

        [StringLength(2000, ErrorMessage = "Historical Medication Data exceeded the max {1} characters")]
        public string HistoricalMedicationData { get; set; }

        [StringLength(2000, ErrorMessage = "Historical Family Data exceeded the max {1} characters")]
        public string HistoricalFamilyData { get; set; }

        [StringLength(2000, ErrorMessage = "Historical Developmental Data exceeded the max {1} characters")]
        public string HistoricalDevelopmentalData { get; set; }

        [StringLength(2000, ErrorMessage = "Historical Behavioral Data exceeded the max {1} characters")]
        public string HistoricalBehavioralData { get; set; }

        [StringLength(2000, ErrorMessage = "Historical Emotional Data exceeded the max {1} characters")]
        public string HistoricalEmotionalData { get; set; }

        [StringLength(2000, ErrorMessage = "Historical Social Data exceeded the max {1} characters")]
        public string HistoricalSocialData { get; set; }

        [StringLength(2000, ErrorMessage = "Historical Psychiatric Data exceeded the max {1} characters")]
        public string HistoricalPsychiatricData { get; set; }

        [StringLength(2000, ErrorMessage = "Historical Recreational Data exceeded the max {1} characters")]
        public string HistoricalRecreationalData { get; set; }

        [StringLength(2000, ErrorMessage = "Historical Nutritional Description exceeded the max {1} characters")]
        public string HistoricalNutritionalDesc { get; set; }

        [StringLength(2000, ErrorMessage = "Historical Legal Issues Description exceeded the max {1} characters")]
        public string HistoricalLegalIssuesDesc { get; set; }

        #endregion Historical Data Tab

        public bool IsCompleted { get; set; }

        [Display(Name = "Assessment Completed  Date")]
        [DataType(DataType.Date, ErrorMessage = "Assessment Completed Date is not a valid date")]
        public DateTime? DateAssessmentCompleted { get; set; }

        [StringLength(50)]
        public string AssessmentCompletedBy { get; set; }

        [Required]
        [StringLength(50)]
        public string RecordedBy { get; set; }

        [Required]
        public DateTime RecordedOn { get; set; } = DateTime.Now;
    }
}