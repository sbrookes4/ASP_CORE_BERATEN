namespace BeratenHealthcareModels
{
    public class Widget
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public WidgetComponents WidgetComponentId { get; set; }

        public int WidgetOrder { get; set; }

        public bool IsMyStuff { get; set; }
    }

    public enum WidgetComponents
    {
        AllOpenCasesWidget = 1,
    }
}