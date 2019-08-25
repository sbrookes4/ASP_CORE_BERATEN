using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeratenHealthcareModels
{
    public class TreatmentGoal
    {
        public TreatmentGoal()
        {
            ModalitiesArray = new List<string>();
        }

        public int Id { get; set; }

        public int TreatmentPlanId { get; set; }

        public virtual TreatmentPlan TreatmentPlan { get; set; }

        // TODO: From TreatmentPlan-Clinical-Illustrative.pdf

        [Required(ErrorMessage = "Problem Description is required")]
        [StringLength(2000, ErrorMessage = "Problem Description exceeded the max {1} characters")]
        public string Problem { get; set; }

        [Required(ErrorMessage = "Goal is required")]
        [StringLength(500, ErrorMessage = "Goal exceeded the max {1} characters")]
        public string Goal { get; set; }

        [Display(Name = "Target Date")]
        [DataType(DataType.Date, ErrorMessage = "Target Date is not a valid date")]
        public DateTime TargetDate { get; set; }

        [StringLength(500, ErrorMessage = "Modalities exceeded the max {1} characters")]
        public string Modalities { get; set; }

        [Display(Name = "Frequency Of Intervention")]
        public Frequency FrequencyOfIntervention { get; set; }

        [Display(Name = "Is Completed")]
        public bool IsCompleted { get; set; }

        public Outcome Outcome { get; set; }

        [Display(Name = "Date Of Outcome")]
        [DataType(DataType.Date, ErrorMessage = "Date Of Outcome is not a valid date")]
        public DateTime? DateOfOutcome { get; set; }

        [Display(Name = "Progress Rating")]
        public ProgressRating ProgressRating { get; set; }

        [Required]
        [StringLength(50)]
        public string RecordedBy { get; set; }

        [Required]
        public DateTime RecordedOn { get; set; } = DateTime.Now;

        [NotMapped]
        public List<string> ModalitiesArray { get; set; }

        [NotMapped]
        public string TargetDateFormatted
        {
            get
            {
                return TargetDate.ToString("MMM-dd-yyyy");
            }
        }
    }

    public enum Outcome
    {
        InProgress = 1,
        Successful = 2,
        NotFulfilled = 3
    }

    public enum ProgressRating
    {
        NotApplicable = 1,
        Detoriation = 2,
        NoProgress = 3,
        MinimalProgress = 4,
        FairProgress = 5,
        GoodImprovement = 6
    }

    public enum Frequency
    {
        Daily = 1,
        Weekly = 2,
        biWeekly = 3,
        Monthly = 4,
    }
}