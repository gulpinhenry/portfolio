using Portfolio.Models;
using Microsoft.EntityFrameworkCore;
namespace Portfolio.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }
        
        public DbSet<Project> Projects { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
