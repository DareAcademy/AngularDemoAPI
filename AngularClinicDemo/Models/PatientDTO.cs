using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AngularClinicDemo.Models
{
    public class PatientDTO
    {
        public int? Id { get; set; }

        [Required]
        public string FName { get; set; }
        [Required]
        public string LName { get; set; }

        [Required]
        [RegularExpression(@"07(7|8|9)\d{7}")]
        public string Phone { get; set; }
        public string? Email { get; set; }

        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public int Country_Id { get; set; }

    }
}
