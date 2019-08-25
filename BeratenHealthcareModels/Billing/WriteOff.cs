namespace BeratenHealthcareModels
{
    public class WriteOff : AccountingEntry, IIncomeEntry
    {
        public WriteOff() { DebitCreditIndicator = DebitCreditIndicator.Credit; }
        public string ReasonForWriteOff { get; set; }
    }
}