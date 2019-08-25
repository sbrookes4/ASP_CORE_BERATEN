//using System;
//using System.ComponentModel.DataAnnotations;

//namespace BeratenHealthcareModels
//{
//    public class ClientContact
//    {
//        public int Id { get; set; }

//        public int ClientId { get; set; }
//        public Client Client { get; set; }

//        [Required( AllowEmptyStrings = false, ErrorMessage = "First Name is Required" )]
//        [StringLength( 50 )]
//        public string FirstName { get; set; }

//        [Required( AllowEmptyStrings = false, ErrorMessage = "Last Name is Required" )]
//        [StringLength( 50 )]
//        public string LastName { get; set; }

//        [StringLength( 100 )]
//        public string Address { get; set; }

//        [StringLength( 100 )]
//        public string City { get; set; }

//        public int? StateLookupId { get; set; }
//        public StateLookup StateLookup { get; set; }

//        [StringLength( 10 )]
//        public string Zip { get; set; }

//        [StringLength( 15 )]
//        public string PrimaryPhone { get; set; }

//        [StringLength( 15 )]
//        public string SecondaryPhone { get; set; }

//        public int GenderLookupId { get; set; }
//        public GenderLookup GenderLookup { get; set; }

//        public int RelationshipTypeLookupId { get; set; }
//        public RelationshipTypeLookup RelationshipTypeLookup { get; set; }

//        public bool IsEmergencyContact { get; set; }
//        public bool IsFinanciallyResponsible { get; set; }

//        [Required]
//        public string RecordedBy { get; set; }

//        [Required]
//        public DateTime RecordedOn { get; set; } = DateTime.Now;

//        public string DisplayName { get { return $"{FirstName} {LastName}"; } }
//        public string CityStateZip { get { return $"{City}, {StateLookup?.Description} {Zip}"; } }
//    }
//}