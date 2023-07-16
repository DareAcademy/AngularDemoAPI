using Microsoft.AspNetCore.Identity;

namespace AngularClinicDemo.data
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
    }
}
