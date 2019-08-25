using System;
using System.ComponentModel.DataAnnotations;

namespace BeratenHealthcareModels
{
    public class ClientSearchCriteria
    {
        [Display(Name = "First Name")]
        [StringLength(100, ErrorMessage = "First Name exceeded the max {1} characters")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(100, ErrorMessage = "Last Name exceeded the max {1} characters")]
        public string LastName { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date, ErrorMessage = "Date of Birth is not a valid date")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(20, ErrorMessage = "Medical Record Number exceeded the max {1} characters")]
        public string MedicalRecordNumber { get; set; }
    }
}