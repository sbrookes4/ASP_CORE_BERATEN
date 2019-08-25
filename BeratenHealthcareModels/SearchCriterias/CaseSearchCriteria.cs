using System;
using System.ComponentModel.DataAnnotations;

namespace BeratenHealthcareModels
{
    public class CaseSearchCriteria
    {
        [Display(Name = "Case Date")]
        public DateTime? CaseDate { get; set; }

        [Display(Name = "To Case Date")]
        [DataType(DataType.Date, ErrorMessage = "Case Date is not a valid")]
        public DateTime? ToCaseDate { get; set; }

        [Display(Name = "Case Number")]
        [StringLength(20, ErrorMessage = "Case Number exceeded the max {1} characters")]
        public string CaseNumber { get; set; }

        [Display(Name = "Case Name")]
        [StringLength(50, ErrorMessage = "Case Name exceeded the max {1} characters")]
        public string CaseName { get; set; }
    }
}