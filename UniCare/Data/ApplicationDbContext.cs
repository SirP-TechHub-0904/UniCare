using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UniCare.Data.Model;
using static System.Net.Mime.MediaTypeNames;

namespace UniCare.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<NewsBlog> NewsBlogs { get; set; }
        public DbSet<Testimony> Testimonies { get; set; }
    }
}
