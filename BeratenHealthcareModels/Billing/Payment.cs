using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BeratenHealthcareModels
{
    public class Payment : AccountsPayableEntry, IBillingEntry
    {
        public Payment() { DebitCreditIndicator = DebitCreditIndicator.Credit;}
        [Required]
        public DateTime PaymentReceivedOn { get; set; }
        public string PaymentIdentifier { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

    }

    public enum PaymentMethod
    {
        Check,
        Card,
        Cash,
        MoneyOrder
    }
}