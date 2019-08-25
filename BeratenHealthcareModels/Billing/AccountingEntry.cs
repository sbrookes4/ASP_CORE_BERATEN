using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeratenHealthcareModels
{
    public abstract class AccountingEntry
    {
        protected AccountingEntry()
        {
            Allocations = new List<AccountingEntryReconciliation>();
        }

        public int Id { get; set; }

        protected DebitCreditIndicator DebitCreditIndicator { get; set; }

        [Required]
        public DateTime PostingDate { get; set; }

        [Required]
        public virtual decimal Amount { get; set; }

        public CancellationReason CancellationReason { get; set; }

        [Required]
        public string RecordedBy { get; set; }

        [Required]
        public DateTime RecordedOn { get; set; }

        public ICollection<AccountingEntryReconciliation> Allocations { get; set; }

        public void AllocateTo(AccountingEntry entry, ReconciliationAllocationType allocType, decimal allocationAmount)
        {
            Allocations.Add(new AccountingEntryReconciliation()
            {
                ReconciliationAllocationType = allocType,
                AllocateFromEntry = this,
                AllocateToEntry = entry,
                AllocatedAmount = allocationAmount
            });
        }

        public void AllocateTo(int entryId, ReconciliationAllocationType allocType, decimal allocationAmount)
        {
            Allocations.Add(new AccountingEntryReconciliation()
            {
                ReconciliationAllocationType = allocType,
                AllocateFromEntry = this,
                AllocateToEntryId = entryId,
                AllocatedAmount = allocationAmount
            });
        }
    }
}