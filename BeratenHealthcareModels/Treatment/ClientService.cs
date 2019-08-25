//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;

//namespace BeratenHealthcareModels
//{
//    public class ClientService
//    {
//        public ClientService()
//        {
//            ProgressNotes = new HashSet<ProgressNote>();
//        }

//        public int Id { get; set; }

//        public int CaseIntakeId { get; set; }
//        public virtual CaseIntake CaseIntake { get; set; }

//        #region Service

//        [Required]
//        public DateTime DateOfService { get; set; }
//        public DateTime? TimeOfService { get; set; }
        
//        public int BillingProcedureId { get; set; }
//        public BillingProcedure BillingProcedure { get; set; }
//        public decimal Quantity { get; set; }

//        #endregion Service

//        public virtual ICollection<ProgressNote> ProgressNotes { get; set; }

//        [Required]
//        [StringLength(50)]
//        public string RecordedBy { get; set; }

//        [Required]
//        public DateTime RecordedOn { get; set; } = DateTime.Now;
//    }
//}