using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            // Empty on purpose
        }

        // DbSets represent the tables inside our database -- it has columns according to the properties of <AppUser>
        public DbSet<AppUser> Users { get; set; }
    }
}