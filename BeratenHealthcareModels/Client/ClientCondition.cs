using System;
using System.ComponentModel.DataAnnotations;

namespace BeratenHealthcareModels
{
    public class ClientCondition
    {
        public int Id { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        [Display(Name = "Residence")]
        public int ResidenceLookupId { get; set; }

        public ResidenceLookup ResidenceLookup { get; set; }

        [Display(Name = "Living Arrangement")]
        public int LivingArrangementLookupId { get; set; }

        public LivingArrangementLookup LivingArrangementLookup { get; set; }

        [Display(Name = "Family Origin")]
        public int FamilyOriginLookupId { get; set; }

        public FamilyOriginLookup FamilyOriginLookup { get; set; }

        [Display(Name = "Income Source")]
        public int IncomeSourceLookupId { get; set; }

        public IncomeSourceLookup IncomeSourceLookup { get; set; }

        [Display(Name = "Monthly Income")]
        public double MonthlyIncome { get; set; }

        public int Dependents { get; set; }

        [Display(Name = "Physician Name")]
        [StringLength(100, ErrorMessage = "Physician Name exceeded the max {1} characters")]
        public string PhysicianName { get; set; }

        [Display(Name = "Physician Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Physician Phone is not a valid phone number")]
        [StringLength(17)]
        public string PhysicianPhone { get; set; }

        [Display(Name = "Clinic Name")]
        [StringLength(500, ErrorMessage = "Clinic Name exceeded the max {1} characters")]
        public string ClinicName { get; set; }

        [Display(Name = "Recent Clinic Visit Date")]
        [DataType(DataType.Date, ErrorMessage = "Recent Clinic Visit Date is not a valid date")]
        public DateTime? RecentClinicVisitDate { get; set; }

        [Required]
        [StringLength(50)]
        public string RecordedBy { get; set; }

        [Required]
        public DateTime RecordedOn { get; set; } = DateTime.Now;
    }
}