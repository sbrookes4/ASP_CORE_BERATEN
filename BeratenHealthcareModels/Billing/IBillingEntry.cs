namespace BeratenHealthcareModels
{
    public interface IBillingEntry
    {
        int? PayorId { get; set; }
        Payor Payor { get; set; }
    }

}