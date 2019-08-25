using System;
using BeratenHealthcareModels;

namespace BeratenHealthcareDataInterfaceLib
{
    public class PaymentSearchCriteria : BaseSearchCriteria
    {
        public int? ClientId { get; set; }
    }
}