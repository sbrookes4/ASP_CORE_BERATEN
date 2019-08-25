using System.ComponentModel.DataAnnotations;

namespace BeratenHealthcareModels
{
    public class AccountsPayableEntry : AccountingEntry
    {
        [Required]
        public CoverageType CoverageType { get; set; }

        public int? ClientId { get; set; }
        protected Client Client { get; set; }

        public int? PayorId { get; set; }
        public Payor Payor { get; set; }
    }
}