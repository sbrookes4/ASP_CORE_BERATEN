using System;
using System.ComponentModel.DataAnnotations;

namespace BeratenHealthcareModels
{
    public class Guardian
    {
        public int Id { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name is Required")]
        [StringLength(100, ErrorMessage = "First Name exceeded the max {1} characters")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is Required")]
        [StringLength(100, ErrorMessage = "Last Name exceeded the max {1} characters")]
        public string LastName { get; set; }

        [Display(Name = "Middle Name")]
        [StringLength(100, ErrorMessage = "Middle Name exceeded the max {1} characters")]
        public string MiddleName { get; set; }

        [Display(Name = "Alias")]
        [StringLength(100, ErrorMessage = "Alias exceeded the max {1} characters")]
        public string Alias { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date, ErrorMessage = "Date of Birth is not a valid date")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(250, ErrorMessage = "Address exceeded the max {1} characters")]
        public string Address { get; set; }

        [StringLength(50, ErrorMessage = "City exceeded the max {1} characters")]
        public string City { get; set; }

        public int? StateLookupId { get; set; }
        public StateLookup StateLookup { get; set; }

        [DataType(DataType.PostalCode)]
        [RegularExpression(@"^\d{5}(?:[-\s]\d{4})?$", ErrorMessage = "Zip Code is not valid")]
        [StringLength(5)]
        public string Zip { get; set; }

        [Display(Name = "Primary Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Primary Phone is not a valid phone number")]
        [StringLength(17)]
        public string PrimaryPhone { get; set; }

        [Display(Name = "Secondary Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Secondary Phone is not a valid phone number")]
        [StringLength(17)]
        public string SecondaryPhone { get; set; }

        public int? GenderLookupId { get; set; }
        public GenderLookup GenderLookup { get; set; }

        public int RelationshipTypeLookupId { get; set; }
        public RelationshipTypeLookup RelationshipTypeLookup { get; set; }

        public int? RaceLookupId { get; set; }
        public RaceLookup RaceLookup { get; set; }

        public int? EthnicityHispanicLookupId { get; set; }
        public EthnicityHispanicLookup EthnicityHispanicLookup { get; set; }

        public bool IsEmergencyContact { get; set; }
        public bool IsFinanciallyResponsible { get; set; }

        [Required]
        [StringLength(50)]
        public string RecordedBy { get; set; }

        [Required]
        public DateTime RecordedOn { get; set; } = DateTime.Now;

        public string DisplayName { get { return $"{FirstName} {LastName}"; } }
        //public string CityStateZip { get { return $"{City}, {State} {Zip}"; } }
    }
}