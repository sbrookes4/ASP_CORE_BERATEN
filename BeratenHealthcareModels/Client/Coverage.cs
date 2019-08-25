using System;
using System.ComponentModel.DataAnnotations;

namespace BeratenHealthcareModels
{
    public class Coverage
    {
        public int Id { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int? PayorId { get; set; }
        public Payor Payor { get; set; }

        [Display(Name = "Coverage Type")]
        public CoverageType CoverageType { get; set; }

        [Display(Name = "Coverage Rank")]
        public CoverageRank CoverageRank { get; set; }

        #region insurance

        [Display(Name = "Effective From")]
        [DataType(DataType.Date, ErrorMessage = "Effective From is not a valid date")]
        public DateTime? EffectiveFrom { get; set; }

        [Display(Name = "Effective To")]
        [DataType(DataType.Date, ErrorMessage = "Effective To is not a valid date")]
        public DateTime? EffectiveUntil { get; set; }

        [Display(Name = "Plan Name")]
        [StringLength(100, ErrorMessage = "Plan Name exceeded the max {1} characters")]
        public string PlanName { get; set; }

        [Display(Name = "Group Number")]
        [StringLength(100, ErrorMessage = "Group Number exceeded the max {1} characters")]
        public string GroupNumber { get; set; }

        [Display(Name = "Member Number")]
        [StringLength(100, ErrorMessage = "Member Number exceeded the max {1} characters")]
        public string MemberNumber { get; set; }

        [Display(Name = "CoPay Amount")]
        [DataType(DataType.Currency, ErrorMessage = "CoPay Amount To is not a valid date")]
        public decimal CoPayAmount { get; set; }

        [Display(Name = "Contracted Rate With Insurer")]
        [DataType(DataType.Currency, ErrorMessage = "Contracted Rate With Insurer To is not a valid date")]
        public decimal ContractedRateWithInsurer { get; set; }

        [Display(Name = "Prior Auth Number")]
        [StringLength(100, ErrorMessage = "Group Number exceeded the max {1} characters")]
        public string PriorAuthNumber { get; set; }

        [Display(Name = "Plan Subscriber Employer")]
        [StringLength(100, ErrorMessage = "Plan Subscriber Employer exceeded the max {1} characters")]
        public string PlanSubscriberEmployer { get; set; }

        [Display(Name = "Insurance Notes")]
        [StringLength(1000, ErrorMessage = "Insurance Notes exceeded the max {1} characters")]
        public string InsuranceNotes { get; set; }

        #endregion insurance

        #region medicaid

        [Display(Name = "Medicaid Number")]
        [StringLength(1000, ErrorMessage = "Medicaid Number exceeded the max {1} characters")]
        public string MedicaidNumber { get; set; }

        [Display(Name = "Medicaid Worker")]
        [StringLength(100, ErrorMessage = "Medicaid Worker exceeded the max {1} characters")]
        public string MedicaidWorker { get; set; }

        [Display(Name = "Medicaid Eligibility Notes")]
        [StringLength(2000, ErrorMessage = "Medicaid Eligibility Notes exceeded the max {1} characters")]
        public string MedicaidEligibilityNotes { get; set; }

        public int? EligibilityLookupId { get; set; }
        public EligibilityLookup EligibilityLookup { get; set; }

        [Display(Name = "Medicare Number")]
        [StringLength(100, ErrorMessage = "Medicare Number exceeded the max {1} characters")]
        public string MedicareNumber { get; set; }

        [Display(Name = "Medicare A")]
        public bool MedicareA { get; set; }

        [Display(Name = "Medicare B")]
        public bool MedicareB { get; set; }

        [Display(Name = "Medicare D")]
        public bool MedicareD { get; set; }

        [Display(Name = "Medicare Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Medicare Phone is not a valid phone number")]
        [StringLength(17)]
        public string MedicarePhone { get; set; }

        [Display(Name = "Medicare Notes")]
        [StringLength(2000, ErrorMessage = "Medicare Notes exceeded the max {1} characters")]
        public string MedicareNotes { get; set; }

        #endregion medicaid

        [Required]
        [StringLength(50)]
        public string RecordedBy { get; set; }

        [Required]
        public DateTime RecordedOn { get; set; } = DateTime.Now;
    }

    public enum CoverageType
    {
        Self = 1,
        Insurance = 2,
        Medicare = 3,
        InsuranceThroughGuardian = 4
    }

    public enum CoverageRank
    {
        Primary = 1,
        Secondary = 2,
        Tritiary = 3
    }
}