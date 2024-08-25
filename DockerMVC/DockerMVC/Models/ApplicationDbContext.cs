using Microsoft.EntityFrameworkCore;

namespace DockerMVC.Models
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext>
        options) : DbContext(options)
    {
        public DbSet<Persona> Productos { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
