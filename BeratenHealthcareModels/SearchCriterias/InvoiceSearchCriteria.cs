using System;

namespace BeratenHealthcareModels
{
    public class InvoiceSearchCriteria : BaseSearchCriteria
    {
        public bool? IsSatisfied { get; set; }
        public int? ClientId { get; set; }
        public int? BillToPartyId { get; set; }
        //public BillTo? BillTo { get; set; }
    }
}