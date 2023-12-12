using linQSami_queries_blazor_server_assignment_4.Models;
using Microsoft.EntityFrameworkCore;

namespace linQSami_queries_blazor_server_assignment_4.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Enrolled> Enrollments { get; set; }
    }

}
