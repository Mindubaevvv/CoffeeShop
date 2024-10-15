using Microsoft.EntityFrameworkCore;
using TestDelete.Models;

namespace TestDelete.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }

    }
}
