namespace BeratenHealthcareModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class AppRole
    {
        public AppRole()
        {
            AppUserRoles = new HashSet<AppUserRole>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public virtual ICollection<AppUserRole> AppUserRoles { get; set; }
    }

    public enum Roles
    {
        SuperAdmin = 1,
        Admin = 2,
        Supervisor = 3,
        IntakeWorker = 4,
        Clinician = 5,
        Therapist = 6,
        CaseSocialWorker = 7,
        Director = 8
    }
}