using System;
using System.ComponentModel.DataAnnotations;

namespace BeratenHealthcareModels
{
    public class CaseDischarge
    {
        public int Id { get; set; }

        public int CaseIntakeId { get; set; }
        public virtual CaseIntake CaseIntake { get; set; }

        [Display(Name = "Discharge Date")]
        [DataType(DataType.Date, ErrorMessage = "Discharge Date is not a valid date")]
        [Required(ErrorMessage = "Discharge Date is required")]
        public DateTime DischargeDate { get; set; }

        [Display(Name = "Discharge Time")]
        [DataType(DataType.Time, ErrorMessage = "Discharge Time is not a valid Time")]
        public DateTime? DischargeTime { get; set; } = DateTime.Now;

        [Display(Name = "Discharge Reason")]
        [Required(ErrorMessage = "Discharge Reason is required")]
        public int DischareReasonLookupId { get; set; }

        public DischareReasonLookup DischareReasonLookup { get; set; }

        #region Transferred Info

        [Display(Name = "Transferred To")]
        [StringLength(200, ErrorMessage = "Transferred To exceeded the max {1} characters")]
        public string TransferredTo { get; set; }

        [Display(Name = "Transferred Date")]
        [DataType(DataType.Date, ErrorMessage = "Transferred Date is not a valid date")]
        public DateTime? TransferredDate { get; set; }

        [Display(Name = "Contact Info")]
        [StringLength(1000, ErrorMessage = "Contact Info exceeded the max {1} characters")]
        public string ContactInfo { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Phone Number is not valid")]
        [StringLength(17)]
        public string Phone { get; set; }

        #endregion Transferred Info

        [Display(Name = "Discharge Recommendation")]
        [StringLength(1000, ErrorMessage = "Discharge Recommendation exceeded the max {1} characters")]
        public string DischargeRecommendation { get; set; }

        [Display(Name = "Possible Post Discharge Problems")]
        [StringLength(1000, ErrorMessage = "Possible Post Discharge Problems exceeded the max {1} characters")]
        public string PossiblePostDischargeProblems { get; set; }

        public bool IsCompleted { get; set; }

        [StringLength(50)]
        public string DischargeCompletedBy { get; set; }

        [Required]
        [StringLength(50)]
        public string RecordedBy { get; set; }

        [Required]
        public DateTime RecordedOn { get; set; } = DateTime.Now;
    }
}