using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeratenHealthcareModels
{
    public class TreatmentPlan
    {
        public TreatmentPlan()
        {
            Goals = new HashSet<TreatmentGoal>();
            AttendingStaffArray = new List<string>();
        }

        public int Id { get; set; }

        public int CaseIntakeId { get; set; }
        public virtual CaseIntake CaseIntake { get; set; }

        [Display(Name = "Plan Date")]
        [DataType(DataType.Date, ErrorMessage = "Plan Date is not a valid date")]
        [Required(ErrorMessage = "Plan Date is required")]
        public DateTime PlanDate { get; set; }

        [Display(Name = "Plan Time")]
        [DataType(DataType.Time, ErrorMessage = "Plan Time is not a valid date")]
        public DateTime? PlanTime { get; set; }

        [StringLength(2000, ErrorMessage = "Plan Name exceeded the max {1} characters")]
        public string PlanName { get; set; }

        [StringLength(2000, ErrorMessage = "Problems exceeded the max {1} characters")]
        public string Problems { get; set; }

        [StringLength(2000, ErrorMessage = "Strengths exceeded the max {1} characters")]
        public string Strengths { get; set; }

        [StringLength(500, ErrorMessage = "Length Of Treatment exceeded the max {1} characters")]
        public string LengthOfTreatment { get; set; }

        [StringLength(1000, ErrorMessage = "Attending Staff Names exceeded the max {1} characters")]
        public string AttendingStaffNames { get; set; }

        [StringLength(1000, ErrorMessage = "Attending Client Family Names exceeded the max {1} characters")]
        public string AttendingClientFamilyNames { get; set; }

        #region SignOff

        public string ApproveddBySupervisor { get; set; }

        public byte[] SupervisorSignature { get; set; }

        [Display(Name = "Date Supervisor Signed")]
        [DataType(DataType.Date, ErrorMessage = "Date Supervisor Signed is not a valid date")]
        public DateTime? DateSupervisorSigned { get; set; }

        [StringLength(50, ErrorMessage = "Client Sign exceeded the max {1} characters")]
        public string ClientSign { get; set; }

        public byte[] ClientDigitalSignature { get; set; }

        [Display(Name = "Date Client Signed")]
        [DataType(DataType.Date, ErrorMessage = "Date Client Signed is not a valid date")]
        public DateTime? DateClientSigned { get; set; }

        [StringLength(50, ErrorMessage = "Reason For No Client Sign exceeded the max {1} characters")]
        public string ReasonForNoClientSign { get; set; }

        public bool IsLocked { get; set; }

        #endregion SignOff

        [Required]
        [StringLength(50)]
        public string RecordedBy { get; set; }

        [Required]
        public DateTime RecordedOn { get; set; } = DateTime.Now;

        [NotMapped]
        public List<string> AttendingStaffArray { get; set; }

        public virtual ICollection<TreatmentGoal> Goals { get; set; }
    }

    //public enum TreatmentPlanType
    //{
    //    Initial,
    //    NintyDayRevision,
    //    SixMonthRevision
    //}
}