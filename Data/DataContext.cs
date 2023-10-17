using Microsoft.EntityFrameworkCore;
using AuthenticationAPI2.Entities;

namespace AuthenticationAPI2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<AppUser> Users { get; set; }
    }
}
