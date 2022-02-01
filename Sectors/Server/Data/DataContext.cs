using Microsoft.EntityFrameworkCore;
using Sectors.Shared;

namespace Sectors.Server.Data
{
    public class DataContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DataContext(IConfiguration configuration, DbContextOptions<DataContext> options) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasData(
                new User {
                    Id = 1,
                    Name = "TestPerson",
                    Agreed = true }
            );

            modelBuilder.Entity<User_Sector>()
                .HasKey(us => new { us.UserId, us.SectorId });

            modelBuilder.Entity<User_Sector>()
                .HasOne(us => us.User)
                .WithMany(us => us.Sectors)
                .HasForeignKey(us => us.UserId);

            modelBuilder.Entity<User_Sector>()
                .HasOne(us => us.Sector)
                .WithMany(us => us.Users)
                .HasForeignKey(u => u.SectorId);

            modelBuilder.Entity<Sector>().HasData(
                 new Sector { Id = 1, SectorId = 1, Name = "Manufacturing" },
                 new Sector { Id = 2, SectorId = 19, Name = "Construction materials" },
                 new Sector { Id = 3, SectorId = 18, Name = "Electronics and Optics" },
                 new Sector { Id = 4, SectorId = 6, Name = "Food and Beverage" },
                 new Sector { Id = 5, SectorId = 342, Name = "Bakery & confectionery products" },
                 new Sector { Id = 6, SectorId = 43, Name = "Beverages" },
                 new Sector { Id = 7, SectorId = 42, Name = "Fish & fish products" },
                 new Sector { Id = 8, SectorId = 40, Name = "Meat & meat products" },
                 new Sector { Id = 9, SectorId = 39, Name = "Milk & dairy products" },
                 new Sector { Id = 10, SectorId = 437, Name = "Other" },
                 new Sector { Id = 11, SectorId = 378, Name = "Sweets & snack food" },
                 new Sector { Id = 12, SectorId = 13, Name = "Furniture" },
                 new Sector { Id = 13, SectorId = 389, Name = "Bathroom/sauna" },
                 new Sector { Id = 14, SectorId = 385, Name = "Bedroom" },
                 new Sector { Id = 15, SectorId = 390, Name = "Children’s room" },
                 new Sector { Id = 16, SectorId = 98, Name = "Kitchen" },
                 new Sector { Id = 17, SectorId = 101, Name = "Living room" },
                 new Sector { Id = 18, SectorId = 392, Name = "Office" },
                 new Sector { Id = 19, SectorId = 394, Name = "Other (Furniture)" },
                 new Sector { Id = 20, SectorId = 341, Name = "Outdoor" },
                 new Sector { Id = 21, SectorId = 99, Name = "Project furniture" },
                 new Sector { Id = 22, SectorId = 12, Name = "Machinery" },
                 new Sector { Id = 23, SectorId = 94, Name = "Machinery components" },
                 new Sector { Id = 24, SectorId = 91, Name = "Machinery equipment/tools" },
                 new Sector { Id = 25, SectorId = 224, Name = "Manufacture of machinery" },
                 new Sector { Id = 26, SectorId = 97, Name = "Maritime" },
                 new Sector { Id = 27, SectorId = 271, Name = "Aluminium and steel workboats" },
                 new Sector { Id = 28, SectorId = 269, Name = "Boat/Yacht building" },
                 new Sector { Id = 29, SectorId = 230, Name = "Ship repair and conversion" },
                 new Sector { Id = 30, SectorId = 93, Name = "Metal structures" },
                 new Sector { Id = 31, SectorId = 508, Name = "Other" },
                 new Sector { Id = 32, SectorId = 227, Name = "Repair and maintenance service" },
                 new Sector { Id = 33, SectorId = 11, Name = "Metalworking" },
                 new Sector { Id = 34, SectorId = 67, Name = "Construction of metal structures" },
                 new Sector { Id = 35, SectorId = 263, Name = "Houses and buildings" },
                 new Sector { Id = 36, SectorId = 267, Name = "Metal products" },
                 new Sector { Id = 37, SectorId = 542, Name = "Metal works" },
                 new Sector { Id = 38, SectorId = 75, Name = "CNC-machining" },
                 new Sector { Id = 39, SectorId = 62, Name = "Forgings, Fasteners" },
                 new Sector { Id = 40, SectorId = 69, Name = "Gas, Plasma, Laser cutting" },
                 new Sector { Id = 41, SectorId = 66, Name = "MIG, TIG, Aluminum welding" },
                 new Sector { Id = 42, SectorId = 9, Name = "Plastic and Rubber" },
                 new Sector { Id = 43, SectorId = 54, Name = "Packaging" },
                 new Sector { Id = 44, SectorId = 556, Name = "Plastic goods" },
                 new Sector { Id = 45, SectorId = 559, Name = "Plastic processing technology" },
                 new Sector { Id = 46, SectorId = 55, Name = "Blowing" },
                 new Sector { Id = 47, SectorId = 57, Name = "Moulding" },
                 new Sector { Id = 48, SectorId = 53, Name = "Plastics welding and processing" },
                 new Sector { Id = 49, SectorId = 560, Name = "Plastic profiles" },
                 new Sector { Id = 50, SectorId = 5, Name = "Printing" },
                 new Sector { Id = 51, SectorId = 148, Name = "Advertising" },
                 new Sector { Id = 52, SectorId = 150, Name = "Book/Periodicals printing" },
                 new Sector { Id = 53, SectorId = 145, Name = "Labelling and packaging printing" },
                 new Sector { Id = 54, SectorId = 7, Name = "Textile and Clothing" },
                 new Sector { Id = 55, SectorId = 44, Name = "Clothing" },
                 new Sector { Id = 56, SectorId = 45, Name = "Textile" },
                 new Sector { Id = 57, SectorId = 8, Name = "Wood" },
                 new Sector { Id = 58, SectorId = 337, Name = "Other (Wood)" },
                 new Sector { Id = 59, SectorId = 51, Name = "Wooden building materials" },
                 new Sector { Id = 60, SectorId = 47, Name = "Wooden houses" },
                 new Sector { Id = 61, SectorId = 3, Name = "Other" },
                 new Sector { Id = 62, SectorId = 37, Name = "Creative industries" },
                 new Sector { Id = 63, SectorId = 29, Name = "Energy technology" },
                 new Sector { Id = 64, SectorId = 33, Name = "Environment" },
                 new Sector { Id = 65, SectorId = 2, Name = "Service" },
                 new Sector { Id = 66, SectorId = 25, Name = "Business services" },
                 new Sector { Id = 67, SectorId = 35, Name = "Engineering" },
                 new Sector { Id = 68, SectorId = 28, Name = "Information Technology and Telecommunications" },
                 new Sector { Id = 69, SectorId = 581, Name = "Data processing, Web portals, E-marketing" },
                 new Sector { Id = 70, SectorId = 576, Name = "Programming, Consultancy" },
                 new Sector { Id = 71, SectorId = 121, Name = "Software, Hardware" },
                 new Sector { Id = 72, SectorId = 122, Name = "Telecommunications" },
                 new Sector { Id = 73, SectorId = 22, Name = "Tourism" },
                 new Sector { Id = 74, SectorId = 141, Name = "Translation services" },
                 new Sector { Id = 75, SectorId = 21, Name = "Transport and Logistics" },
                 new Sector { Id = 76, SectorId = 111, Name = "Air" },
                 new Sector { Id = 77, SectorId = 114, Name = "Rail" },
                 new Sector { Id = 78, SectorId = 112, Name = "Road" },
                 new Sector { Id = 79, SectorId = 113, Name = "Water" }
            );
        }

        public DbSet<User> UsersDb { get; set; }

        public DbSet<Sector> SectorsDb { get; set; }
        public DbSet<User_Sector> User_Sectors { get; set; }
    }
}
