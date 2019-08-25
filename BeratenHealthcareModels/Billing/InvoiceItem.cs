using System;
using System.ComponentModel.DataAnnotations;

namespace BeratenHealthcareModels
{
    public class InvoiceItem 
    {
        public InvoiceItem(BillingProcedure billingCode) : this()
        {
            BillingProcedure = billingCode;
        }

        private InvoiceItem()
        {
            IsBillable = true;
        }

        public int Id { get; set; }

        public int? InvoiceId { get; set; } // ?? Why nullable?
        protected Invoice Invoice { get; set; }
        
        public int ClientId { get; set; }
        public Client Client { get; set; }
       
        public int BillingProcedureId { get; set; } // This should be the Id of Progress Notes??
        public BillingProcedure BillingProcedure { get; set; }
                        
        [Required]
        public decimal Quantity { get; set; } // Should this be the quanity coming from BillingCode??
        public decimal? OverrideAmount { get; set; }
        public decimal? OverrideUnitPrice { get; set; }
        
        public decimal Amount
        {
            get { return OverrideAmount ?? (OverrideUnitPrice ?? (BillingProcedure != null ? BillingProcedure.UnitPrice : 0)) * Quantity; }
        }

        public bool IsBillable { get; set; }

        [Required]
        [StringLength(50)]
        public string RecordedBy { get; set; }

        [Required]
        public DateTime RecordedOn { get; set; } = DateTime.Now;
    }


}