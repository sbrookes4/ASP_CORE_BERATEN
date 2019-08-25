using System;
using System.ComponentModel.DataAnnotations;

namespace BeratenHealthcareModels
{
    public class Payor //: IEntityAudit
    {
        public int Id { get; set; }
        public PayorType PayorType { get; set; }

        [StringLength(250)]
        public string PayorName { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(100)]
        public string City { get; set; }

        public int StateLookupId { get; set; }
        public StateLookup StateLookup { get; set; }

        [StringLength(10)]
        public string Zip { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(15)]
        public string Fax { get; set; }

        [Required]
        [StringLength(50)]
        public string RecordedBy { get; set; }

        public DateTime RecordedOn { get; set; }
    }

    public enum PayorType
    {
        InsuranceProvider,
        ThirdParty
    }
}