using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeratenHealthcareModels
{
    public class Invoice : AccountsPayableEntry, IBillingEntry
    {
        public Invoice() 
        {
            InvoiceItems = new List<InvoiceItem>();
            DebitCreditIndicator = DebitCreditIndicator.Debit;
        }

        public override decimal Amount { get { return InvoiceItems != null ? InvoiceItems.Sum(s => s.Amount) : 0; }}

        [Required]
        [StringLength(20)]
        public string InvoiceNumber { get; set; }

        [Required]
        public DateTime InvoiceDate { get; set; }        

        [Required]
        public DateTime DueDate { get; set; }

        public ICollection<InvoiceItem> InvoiceItems { get; set; }

        public int DaysLate(DateTime reference)
        {
            var days = (reference - DueDate).TotalDays;
            return (int) (days > 0 ? Math.Floor(days) : 0);
        }

        public static Invoice FromProgressNote(ProgressNote progressNote, string invoiceNumber, DateTime invoiceDate, DateTime dueDate, CoverageType coverageType, Payor payor = null)
        {    
            //TODO:
            return null;
            //return new Invoice()
            //{
            //    ClientId = progressNote.ClientId,
            //    InvoiceItems = new InvoiceItem[] { },
            //    InvoiceNumber = invoiceNumber,
            //    DueDate = dueDate,
            //    InvoiceDate = invoiceDate,
            //    Amount = progressNote.InvoiceItem.Amount,
            //    CoverageType = coverageType,
            //    Payor = payor,
            //    PostingDate = invoiceDate,                               
            //};
        }
    }
}
