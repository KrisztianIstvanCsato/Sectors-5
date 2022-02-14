using Microsoft.EntityFrameworkCore;
using Sectors.Server.Interfaces;
using Sectors.Shared;
using Sectors.Shared.Models;

namespace Sectors.Server.Data
{
    public class DataContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly ISeeder _seeder;
        public DataContext(IConfiguration configuration, DbContextOptions<DataContext> options, ISeeder seeder) : base(options)
        {
            _configuration = configuration;
            _seeder = seeder;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(_seeder.GetUsers());

            modelBuilder.Entity<Sector>()
                .HasData(_seeder.GetSectors());

            modelBuilder.Entity<UserSector>()
                .HasKey(us => new { us.SectorId, us.UserId });

            modelBuilder.Entity<UserSector>()
                .HasOne(us => us.User)
                .WithMany(us => us.Sectors)
                .HasForeignKey(us => us.UserId);

            modelBuilder.Entity<UserSector>()
                .HasOne(us => us.Sector)
                .WithMany(us => us.Users)
                .HasForeignKey(us => us.SectorId);

            modelBuilder.Entity<UserSector>()
                .HasData(_seeder.GetUserSectorSamples());
        }

        public DbSet<User> User { get; set; }
        public DbSet<Sector> Sector { get; set; }
        public DbSet<UserSector> UserSector { get; set; }
    }
}
