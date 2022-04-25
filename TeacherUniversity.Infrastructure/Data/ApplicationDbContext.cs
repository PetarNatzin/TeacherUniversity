using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TeacherUniversity.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Inspector> Inspectors { get; set; }

        public DbSet<Lecturer> Lecturers { get; set; }

        public DbSet<Candidature> Candidatures { get; set; }

        public DbSet<Commission> Commissions { get; set; }

        public DbSet<Protocol> Protocols { get; set; }
    }
}