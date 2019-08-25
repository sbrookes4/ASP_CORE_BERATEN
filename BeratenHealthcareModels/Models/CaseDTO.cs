using System;

namespace BeratenHealthcareModels
{
    public class CaseIntakeDTO
    {
        public int Id { get; set; }

        public string CaseNumber { get; set; }

        public string CaseName { get; set; }

        public DateTime IntakeDate { get; set; }

        public DateTime IntakeTime { get; set; }

        public string IntakeMethod { get; set; }

        public string PresentingProblems { get; set; }

        public int ClientId { get; set; }

        public string ClientName { get; set; }

        public string ClientMRNumber { get; set; }

        public string ClientDOB { get; set; }

        public string ClientAddress { get; set; }
    }
}