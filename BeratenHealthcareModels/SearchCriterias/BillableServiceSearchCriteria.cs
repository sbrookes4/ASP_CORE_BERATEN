using System;

namespace BeratenHealthcareModels
{
    public class BillableServiceSearchCriteria : BaseSearchCriteria
    {
        public bool? IsBillable { get; set; }
        public bool? HasBeenInvoiced { get; set; }
        public int? ClientId { get; set; }

    }
}