using Fintranet.MVP.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fintranet.MVP.Infrastracture.Repositories
{
    public class FintranetSampleDbContext : DbContext
    {

        public DbSet<PassedLogEntity> PassedTimeLogs { get; set; }
        public DbSet<VehicleEntity> Vehicles { get; set; }
        public DbSet<LocationEntity> locations { get; set; }



        public FintranetSampleDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
