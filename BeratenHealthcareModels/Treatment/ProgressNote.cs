using System;
using System.ComponentModel.DataAnnotations;

namespace BeratenHealthcareModels
{
    public class ProgressNote
    {
        public int Id { get; set; }

        public int CaseIntakeId { get; set; }
        public virtual CaseIntake CaseIntake { get; set; }

        //public int? InvoiceItemId { get; set; }
        //public InvoiceItem InvoiceItem { get; set; }

        #region Service

        [Required]
        public DateTime DateOfService { get; set; }

        public DateTime? TimeOfService { get; set; }

        public float? Duration { get; set; }

        public bool IsNonBillable { get; set; }

        public int? BillingProcedureId { get; set; }
        public BillingProcedure BillingProcedure { get; set; }

        //public float? Quantity { get; set; }

        [Required]
        public int TreatmentModalityLookupId { get; set; }
        public TreatmentModalityLookup TreatmentModalityLookup { get; set; }

        [Required]
        public int ServiceLocationLookupId { get; set; }
        public ServiceLocationLookup ServiceLocationLookup { get; set; }

        [Required]
        public int ContactMethodLookupId { get; set; }
        public ContactMethodLookup ContactMethodLookup { get; set; }

        [Required]
        public int AppointmentStatusLookupId { get; set; }
        public AppointmentStatusLookup AppointmentStatusLookup { get; set; }

        public int? TreatmentGoalId { get; set; }
        public TreatmentGoal TreatmentGoal { get; set; }

        [Required]
        public int AppUserId { get; set; }

        public AppUser AppUser { get; set; }

        #endregion Service

        public string Narrative { get; set; }

        public bool IsCompleted { get; set; }
        public bool NotifyOthers { get; set; }

        [Required]
        [StringLength(50)]
        public string RecordedBy { get; set; }

        [Required]
        public DateTime RecordedOn { get; set; } = DateTime.Now;

        public string DateTimeFormat {
            get {
                string time = string.Empty;

                if (TimeOfService.HasValue)
                    time = TimeOfService.Value.ToShortTimeString();

                return DateOfService.ToString("MMM-dd-yyyy") + " " + time;
            }
        }
    }
}