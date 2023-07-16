using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace AngularClinicDemo.data
{
    public class ClinicContext: IdentityDbContext<ApplicationUser> //DbContext
    {
        private readonly IConfiguration config;

        public ClinicContext(IConfiguration _config)
        {
            config = _config;
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Patient> Patients { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config.GetConnectionString("clinicConnection"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
