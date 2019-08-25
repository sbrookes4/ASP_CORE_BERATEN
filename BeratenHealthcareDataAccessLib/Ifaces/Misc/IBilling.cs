using System.Collections.Generic;
using BeratenHealthcareModels;

namespace BeratenHealthcareDataInterfaceLib
{
    public interface IBilling
    {
        Invoice GetInvoice(int invoiceId);
        IList<Invoice> GetInvoices(InvoiceSearchCriteria invoiceSearchCriteria = null); 
        int CreateInvoice(Invoice invoice);
        Payment GetPayment(int paymentId);
        IList<Payment> GetPayments(PaymentSearchCriteria paymentSearchCriteria = null); 
        int PostPayment(Payment payment);
        Payor GetPayor(int id);
        //IList<Payor> GetPayors(PayorSearchCriteria payorSearchCriteria = null);
    }
}