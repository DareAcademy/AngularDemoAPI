using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularClinicDemo.data
{
    [Table("Patients")]
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FName { get; set; }
        [Required]
        [StringLength(50)]
        public string LName { get; set; }

        [Required]
        public string Phone { get; set; }
        public string? Email { get; set; }

        [Required]
        public DateTime DOB { get; set; }
        [Required]
        [ForeignKey("country")]
        public int Country_Id { get; set; }

        public Country country { get; set; }
    }
}
