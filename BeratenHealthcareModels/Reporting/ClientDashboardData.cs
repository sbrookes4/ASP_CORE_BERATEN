using System.Collections;

namespace BeratenHealthcareModels
{
    public class ClientDashboardData
    {
        public int ClientId { get; set; }
        public int SessionsCount { get; set; }
        public int SessionsAttended { get; set; }
        public int SessionsCancelled { get; set; }
        public int SessionsNoShow { get; set; }
    }
}