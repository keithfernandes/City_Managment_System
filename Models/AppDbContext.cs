using Microsoft.EntityFrameworkCore;
using ProjCRS.Models;

namespace ProjCRS.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
        {
        }
        public DbSet<ProjCRS.Models.Criminal> Criminal { get; set; }
        public DbSet<ProjCRS.Models.CrimeLocation> CrimeLocation { get; set; }
        public DbSet<ProjCRS.Models.CriminalActivity> CriminalActivity { get; set; }
        public DbSet<ProjCRS.Models.CriminalCode> CriminalCode { get; set; }
    }
}