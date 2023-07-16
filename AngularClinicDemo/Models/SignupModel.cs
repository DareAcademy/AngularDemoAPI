using System.ComponentModel.DataAnnotations;

namespace AngularClinicDemo.Models
{
    public class SignupModel
    {

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [RegularExpression(@"07(7|8|9)\d{7}")]
        public string Phone { get; set; }

    }
}
