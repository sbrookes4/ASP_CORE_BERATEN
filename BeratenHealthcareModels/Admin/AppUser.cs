namespace BeratenHealthcareModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class AppUser
    {
        public AppUser()
        {
            AppUserRoles = new HashSet<AppUserRole>();
        }

        public int Id { get; set; }

        //public int FacilityId { get; set; }
        //public Facility Facility { get; set; }

        [Required(ErrorMessage = "Login ID")]
        [StringLength(50, ErrorMessage = "Login ID exceeded the max {1} characters")]
        public string LoginId { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Password must be a minimum length of 6 and a maximum length of 20")]
        public string Password { get; set; }

        public bool IsActive { get; set; }

        [StringLength(50, ErrorMessage = "Case Name exceeded the max {1} characters")]
        public string Prefix { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, ErrorMessage = "Case Name exceeded the max {1} characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, ErrorMessage = "First Name exceeded the max {1} characters")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "Suffix exceeded the max {1} characters")]
        public string Suffix { get; set; }

        [Display(Name = "Cell Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Cell Phone is not a valid phone number")]
        [StringLength(17)]
        public string CellPhone { get; set; }

        [StringLength(50)]
        public string DisplayName
        {
            get
            {
                return string.Format("{0}{1}{2}",
                    (FirstName + " "),
                    (LastName + " "),
                    (Suffix)
                    ).Trim();
            }
        }

        public DateTime LastActiveDate { get; set; }

        [Required]
        public DateTime RecordedOn { get; set; }

        [Required]
        public string RecordedBy { get; set; }

        public virtual ICollection<AppUserRole> AppUserRoles { get; set; }
    }
}