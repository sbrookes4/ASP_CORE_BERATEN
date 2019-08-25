using System;

namespace BeratenHealthcareModels
{
    public class BillingProcedure
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string CPTCode { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }        
        public UnitOfMeasure UnitOfMeasure { get; set; }

        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
    }

    public enum UnitOfMeasure
    {
        Hour,
        Minutes
    }
}