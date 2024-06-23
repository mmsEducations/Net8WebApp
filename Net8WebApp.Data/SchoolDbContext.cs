using Microsoft.EntityFrameworkCore;

namespace Net8WebApp.Data
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Education;Trusted_Connection=True;Encrypt=False;");
        }
    }
}
