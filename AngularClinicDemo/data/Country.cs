using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularClinicDemo.data
{
    [Table("Countries")]
    public class Country
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Patient> Patients { get; set; }
    }
}
