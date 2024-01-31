using _30_days.Models;
using Microsoft.EntityFrameworkCore;

namespace _30_days.DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories{ get; set; }
    }
        
}
