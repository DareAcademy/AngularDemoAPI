using System.ComponentModel.DataAnnotations;

namespace AngularClinicDemo.Models
{
    public class RoleModel
    {
        [Required]
        public string Name { get; set; }
    }
}
