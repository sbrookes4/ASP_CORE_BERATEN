using System.ComponentModel.DataAnnotations;

namespace BeratenHealthcareModels
{
    public class AccountingEntryReconciliation
    {
        public int Id { get; set; }
        public ReconciliationAllocationType ReconciliationAllocationType { get; set; }
        public int AllocateToEntryId { get; set; }
        public AccountingEntry AllocateToEntry { get; set; }
        public int AllocateFromEntryId { get; set; }
        public AccountingEntry AllocateFromEntry { get; set; }
        [Required]
        public decimal AllocatedAmount { get; set; }
    }

    public enum ReconciliationAllocationType
    {
        PaymentToInvoice
    }
}