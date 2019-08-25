using System;

namespace BeratenHealthcareModels
{
    public class ClientDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string MedicalRecordNumber { get; set; }

        public string Gender { get; set; }

        public string Race { get; set; }
    }
}