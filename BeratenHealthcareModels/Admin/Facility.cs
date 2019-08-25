namespace BeratenHealthcareModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Facility
    {
        public Facility()
        {
            AppUsers = new HashSet<AppUser>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Facility Code")]
        [StringLength(15, ErrorMessage = "Facility Code exceeded the max {1} characters")]
        public string FacilityCode { get; set; }

        [Required(ErrorMessage = "Name")]
        [StringLength(500, ErrorMessage = "Name exceeded the max {1} characters")]
        public string Name { get; set; }

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

        [Required]
        [StringLength(50)]
        public string RecordedBy { get; set; }

        [Required]
        public DateTime RecordedOn { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; }
    }
}