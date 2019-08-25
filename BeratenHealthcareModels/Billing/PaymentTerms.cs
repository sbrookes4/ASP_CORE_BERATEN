using System;
using System.ComponentModel.DataAnnotations;

namespace BeratenHealthcareModels
{
    //public class PaymentTerms
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //    [Required]
    //    public int DueDays { get; set; }
    //    public int DiscountDays { get; set; }
    //    public decimal DiscountRate { get; set; }

    //    public DateTime GetDueDate(DateTime invoiceDate)
    //    {
    //        return invoiceDate.AddDays(DueDays);
    //    }

    //    public decimal GetDiscountAmount(DateTime invoiceDate, DateTime paymentDate, decimal invoiceTotal)
    //    {
    //        return invoiceDate.AddDays(DiscountDays) >= paymentDate ? invoiceTotal * DiscountRate : 0;
    //    }
    //    public decimal LateFee { get; set; }
    //}
}