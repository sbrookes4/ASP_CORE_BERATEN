using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeratenHealthcareModels
{
    public class CreditMemo : AccountingEntry, IBillingEntry
    {
        public CreditMemo() { DebitCreditIndicator = DebitCreditIndicator.Credit;}

        public int? PayorId { get; set; }
        public Payor Payor { get; set; }
        //public BillTo BillTo { get; set; }
    }
}