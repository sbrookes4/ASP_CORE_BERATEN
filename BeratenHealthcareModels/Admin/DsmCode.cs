namespace BeratenHealthcareModels
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class DsmCode
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Label { get; set; }
        public string Chapter { get; set; }
    }
}
