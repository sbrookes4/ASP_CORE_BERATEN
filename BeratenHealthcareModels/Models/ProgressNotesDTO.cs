using System;

namespace BeratenHealthcareModels
{
    public class ProgressNotesDTO  
    {
        public int Id { get; set; }

        public int CaseIntakeId { get; set; }

        public DateTime DateOfService { get; set; }

        public DateTime? TimeOfService { get; set; }

        public string ContactMethodDesc { get; set; }

        public string Narrative { get; set; }

        public bool IsCompleted { get; set; }

        public string DateTimeFormat { get; set; }

        public string TreatmentModalityDesc { get; set; }

        public string ServiceLocationDesc { get; set; }

        public string RecordedBy { get; set; }

        public DateTime RecordedOn { get; set; }

        public string AuditInfo
        {
            get
            {
                return RecordedOn.ToString("MMM-dd-yyyy") + " by " + RecordedBy;
            }
        }
    }
}