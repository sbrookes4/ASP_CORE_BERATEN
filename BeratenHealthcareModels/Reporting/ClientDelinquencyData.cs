using System.Collections.Generic;

namespace BeratenHealthcareModels
{
    public class ClientDelinquencyData
    {
        public int ClientId { get; set; }
        public decimal DelinquentAmount { get; set; }
        public int DaysLate { get; set; }
        public IList<ProgressNote> DelinquentProgressNotes { get; set; }
        public IList<Invoice> DelinquentInvoices { get; set; }
    }
}