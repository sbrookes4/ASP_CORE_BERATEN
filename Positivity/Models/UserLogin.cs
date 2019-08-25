using System.ComponentModel.DataAnnotations;

namespace Positivity.Models
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Enter your Login ID")]
        public string LoginID { get; set; }

        [Required(ErrorMessage = "Enter your Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}