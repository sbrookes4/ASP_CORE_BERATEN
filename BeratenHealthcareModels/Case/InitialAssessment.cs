//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;

//namespace BeratenHealthcareModels
//{
//    public class InitialAssessment
//    {
//        public int Id { get; set; }

//        public int ClientId { get; set; }
//        public virtual Client Client { get; set; }

//        [StringLength(100)]
//        public string CaseName { get; set; }

//        [Required]
//        [DataType(DataType.Date)]
//        public DateTime IntakeDate { get; set; }

//        public int IntakeMethodLookupId { get; set; }
//        public IntakeMethodLookup IntakeMethodLookup { get; set; }

//        public int? ResidenceLookupId { get; set; }
//        public ResidenceLookup ResidenceLookup { get; set; }

//        public int LivingArrangementLookupId { get; set; }
//        public LivingArrangementLookup LivingArrangementLookup { get; set; }

//        public int? IncomeSourceLookupId { get; set; }
//        public IncomeSourceLookup IncomeSourceLookup { get; set; }

//        public double MonthlyIncome { get; set; }
//        public int Dependents { get; set; }

//        public int UrgencyLevelLookupId { get; set; }
//        public UrgencyLevelLookup UrgencyLevelLookup { get; set; }

//        public int FamilyOriginLookupId { get; set; }
//        public FamilyOriginLookup FamilyOriginLookup { get; set; }

//        public int? ReferralSourceLookupId { get; set; }
//        public ReferralSourceLookup ReferralSourceLookup { get; set; }

//        [StringLength(100)]
//        public string ReferralContactName { get; set; }

//        [StringLength(500)]
//        public string ReferralReason { get; set; }

//         public int FirstDispositionLookupId { get; set; }
//        public FirstDispositionLookup FirstDispositionLookup { get; set; } // Intake Decision

//        [StringLength(100)]
//        public string IntakeCompletedBy { get; set; }

//        public bool IsCompleted { get; set; }
//        public DateTime? DateIntakeCompleted { get; set; }    
//    }
//}
