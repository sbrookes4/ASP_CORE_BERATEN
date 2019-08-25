namespace BeratenHealthcareModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    public class Client
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string MedicalRecordNumber { get; set; }

        #region Demographics

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
        [Required(ErrorMessage = "Date of Birth is required")]
        [DataType(DataType.Date, ErrorMessage = "Date of Birth is not a valid date")]
        public DateTime DateOfBirth { get; set; }

        [StringLength(11, ErrorMessage = "SSN is not valid")]
        public string SSN { get; set; }

        [Display(Name = "Gender")]
        public int GenderLookupId { get; set; }

        public GenderLookup GenderLookup { get; set; }

        [Display(Name = "Race")]
        public int RaceLookupId { get; set; }

        public RaceLookup RaceLookup { get; set; }

        [Display(Name = "Ethnicity Hispanic")]
        public int EthnicityHispanicLookupId { get; set; }

        public EthnicityHispanicLookup EthnicityHispanicLookup { get; set; }

        [Display(Name = "Marital Status")]
        public int MaritalStatusLookupId { get; set; }

        public MaritalStatusLookup MaritalStatusLookup { get; set; }

        [Display(Name = "Special Needs")]
        public int SpecialNeedsLookupId { get; set; }

        public SpecialNeedsLookup SpecialNeedsLookup { get; set; }

        [Display(Name = "Preferred Language")]
        public int PreferredLanguageLookupId { get; set; }

        public PreferredLanguageLookup PreferredLanguageLookup { get; set; }

        public byte[] Photo { get; set; }

        #endregion Demographics

        #region Primary Address

        public bool IsBillingAddress { get; set; }

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

        [StringLength(50, ErrorMessage = "County exceeded the max {1} characters")]
        public string County { get; set; }

        #endregion Primary Address

        //#region Billing Address

        //public bool IsBillingAddressSameAsPrimary { get; set; }

        //[StringLength( 100 )]
        //public string BillingAddress { get; set; }

        //[StringLength( 100 )]
        //public string BillingCity { get; set; }

        //[StringLength( 50 )]
        //public string BillingState { get; set; }

        //[StringLength( 10 )]
        //public string BillingZip { get; set; }

        //#endregion Billing Address

        #region Phone

        [Display(Name = "Primary Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Primary Phone is not a valid phone number")]
        [StringLength(17)]
        public string PrimaryPhone { get; set; }

        public bool CanLeaveMsgOnPriPhone { get; set; }

        [Display(Name = "Secondary Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Secondary Phone is not a valid phone number")]
        [StringLength(17)]
        public string SecondaryPhone { get; set; }

        public bool CanLeaveMsgOnSecPhone { get; set; }

        #endregion Phone

        [Required]
        [StringLength(50)]
        public string RecordedBy { get; set; }

        [Required]
        public DateTime RecordedOn { get; set; } = DateTime.Now;

        public int Age
        {
            get
            {
                return (int)(DateTime.Now - DateOfBirth).TotalDays / 365;
            }
        }

        public string CityStateZip
        {
            get
            {
                return $"{City}, {StateLookup?.Description} {Zip}";
            }
        }

        public string DisplayName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string DateOfBirthFormatted
        {
            get
            {
                return DateOfBirth.ToString("MMM-dd-yyyy");
            }
        }

        public string DisplayAddress
        {
            get
            {
                StringBuilder address = new StringBuilder();
                if (!string.IsNullOrEmpty(Address))
                {
                    address.Append(Address);
                    address.Append(", ");
                }

                if (!string.IsNullOrEmpty(City))
                {
                    address.Append(City);
                    address.Append(", ");
                }

                if (StateLookup?.Description != null)
                {
                    address.Append(StateLookup?.Description);
                    address.Append(" ");
                }

                address.Append(Zip);

                return address.ToString();
            }
        }
    }
}