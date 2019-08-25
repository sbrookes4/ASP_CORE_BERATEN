//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BeratenHealthcareModels
//{
//    public class AdmitDischarge : IEntityAudit
//    {
//        public int Id { get; set; }

//        #region Admit
//        [Required]
//        public virtual int ClientId { get; set; }
//        public virtual Client Client { get; set; }
                               
//        [Column(TypeName = "date")]        
//        public  DateTime DateOpened { get; set; }

//        public int TherapistId { get; set; }
//        public Therapist Therapist { get; set; } 
       

//        public  int? ReferralSourceLookupId { get; set; }
//        public ReferralSourceLookup ReferralSourceLookup { get; set; }        
        
//        public  string ReferralInfo { get; set; }        
//        public  string ReferralReason { get; set; }
//        public string AdmitNotes { get; set; }

//        #endregion Admit

//        #region Discharge
//        [Column(TypeName = "date")]
//        public DateTime? DateDischarged { get; set; }
//        public  int? DischargeReasonId { get; set; }
//        public string DischargeNotes { get; set; }      
//        public  string DischargeRecommendation { get; set; }        
//        public string PossiblePostDischargeProblems { get; set; }
//        public int? ReferralOutSourceLookupId { get; set; }
//        public ReferralSourceLookup ReferralOutSourceLookup { get; set; }   

//        #endregion

//        public int InitialAssessmentId { get; set; }
//        public virtual Assessment InitialAssessment { get; set; }

//        public string RecordedBy { get; set; }
//        public DateTime RecordedOn { get; set; }
//    }
//}
