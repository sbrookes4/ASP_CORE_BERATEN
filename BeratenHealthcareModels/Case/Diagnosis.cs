//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;

//namespace BeratenHealthcareModels
//{
//    public class Diagnosis
//    {
//        public int Id { get; set; }

//        public int CaseIntakeId { get; set; }
//        public virtual CaseIntake CaseIntake { get; set; }        

//        #region Diagnosis Tab

//        public int DsmCodeId { get; set; }
//        public DsmCode DsmCode { get; set; }                
//        public string DiagnosisComments { get; set; }

//        #endregion Diagnosis Tab
        
//        [Required]
//        [StringLength(50)]
//        public string RecordedBy { get; set; }

//        [Required]
//        public DateTime RecordedOn { get; set; } = DateTime.Now;
//    }
//}