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
            modelBuilder.Entity<UserModel>()
                .HasData(
                new UserModel {
                    Id = 1,
                    Name = "TestPerson",
                    Agreed = true }
            );

            modelBuilder.Entity<User_Sector_Model>()
                .HasData(
                new User_Sector_Model { Id = 1, UserId = 1, SectorId = 1 },
                new User_Sector_Model { Id = 2, UserId = 1, SectorId = 2 });

            modelBuilder.Entity<User_Sector_Model>()
                .HasOne(u => u.User)
                .WithMany(s => s.UserSectors)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<User_Sector_Model>()
                .HasOne(u => u.Sector)
                .WithMany(s => s.UserSectors)
                .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<SectorModel>().HasData(
                 new SectorModel { Id = 1, SectorId = 1, Name = "Manufacturing" },
                 new SectorModel { Id = 2, SectorId = 19, Name = "Construction materials" },
                 new SectorModel { Id = 3, SectorId = 18, Name = "Electronics and Optics" },
                 new SectorModel { Id = 4, SectorId = 6, Name = "Food and Beverage" },
                 new SectorModel { Id = 5, SectorId = 342, Name = "Bakery & confectionery products" },
                 new SectorModel { Id = 6, SectorId = 43, Name = "Beverages" },
                 new SectorModel { Id = 7, SectorId = 42, Name = "Fish & fish products" },
                 new SectorModel { Id = 8, SectorId = 40, Name = "Meat & meat products" },
                 new SectorModel { Id = 9, SectorId = 39, Name = "Milk & dairy products" },
                 new SectorModel { Id = 10, SectorId = 437, Name = "Other" },
                 new SectorModel { Id = 11, SectorId = 378, Name = "Sweets & snack food" },
                 new SectorModel { Id = 12, SectorId = 13, Name = "Furniture" },
                 new SectorModel { Id = 13, SectorId = 389, Name = "Bathroom/sauna" },
                 new SectorModel { Id = 14, SectorId = 385, Name = "Bedroom" },
                 new SectorModel { Id = 15, SectorId = 390, Name = "Children’s room" },
                 new SectorModel { Id = 16, SectorId = 98, Name = "Kitchen" },
                 new SectorModel { Id = 17, SectorId = 101, Name = "Living room" },
                 new SectorModel { Id = 18, SectorId = 392, Name = "Office" },
                 new SectorModel { Id = 19, SectorId = 394, Name = "Other (Furniture)" },
                 new SectorModel { Id = 20, SectorId = 341, Name = "Outdoor" },
                 new SectorModel { Id = 21, SectorId = 99, Name = "Project furniture" },
                 new SectorModel { Id = 22, SectorId = 12, Name = "Machinery" },
                 new SectorModel { Id = 23, SectorId = 94, Name = "Machinery components" },
                 new SectorModel { Id = 24, SectorId = 91, Name = "Machinery equipment/tools" },
                 new SectorModel { Id = 25, SectorId = 224, Name = "Manufacture of machinery" },
                 new SectorModel { Id = 26, SectorId = 97, Name = "Maritime" },
                 new SectorModel { Id = 27, SectorId = 271, Name = "Aluminium and steel workboats" },
                 new SectorModel { Id = 28, SectorId = 269, Name = "Boat/Yacht building" },
                 new SectorModel { Id = 29, SectorId = 230, Name = "Ship repair and conversion" },
                 new SectorModel { Id = 30, SectorId = 93, Name = "Metal structures" },
                 new SectorModel { Id = 31, SectorId = 508, Name = "Other" },
                 new SectorModel { Id = 32, SectorId = 227, Name = "Repair and maintenance service" },
                 new SectorModel { Id = 33, SectorId = 11, Name = "Metalworking" },
                 new SectorModel { Id = 34, SectorId = 67, Name = "Construction of metal structures" },
                 new SectorModel { Id = 35, SectorId = 263, Name = "Houses and buildings" },
                 new SectorModel { Id = 36, SectorId = 267, Name = "Metal products" },
                 new SectorModel { Id = 37, SectorId = 542, Name = "Metal works" },
                 new SectorModel { Id = 38, SectorId = 75, Name = "CNC-machining" },
                 new SectorModel { Id = 39, SectorId = 62, Name = "Forgings, Fasteners" },
                 new SectorModel { Id = 40, SectorId = 69, Name = "Gas, Plasma, Laser cutting" },
                 new SectorModel { Id = 41, SectorId = 66, Name = "MIG, TIG, Aluminum welding" },
                 new SectorModel { Id = 42, SectorId = 9, Name = "Plastic and Rubber" },
                 new SectorModel { Id = 43, SectorId = 54, Name = "Packaging" },
                 new SectorModel { Id = 44, SectorId = 556, Name = "Plastic goods" },
                 new SectorModel { Id = 45, SectorId = 559, Name = "Plastic processing technology" },
                 new SectorModel { Id = 46, SectorId = 55, Name = "Blowing" },
                 new SectorModel { Id = 47, SectorId = 57, Name = "Moulding" },
                 new SectorModel { Id = 48, SectorId = 53, Name = "Plastics welding and processing" },
                 new SectorModel { Id = 49, SectorId = 560, Name = "Plastic profiles" },
                 new SectorModel { Id = 50, SectorId = 5, Name = "Printing" },
                 new SectorModel { Id = 51, SectorId = 148, Name = "Advertising" },
                 new SectorModel { Id = 52, SectorId = 150, Name = "Book/Periodicals printing" },
                 new SectorModel { Id = 53, SectorId = 145, Name = "Labelling and packaging printing" },
                 new SectorModel { Id = 54, SectorId = 7, Name = "Textile and Clothing" },
                 new SectorModel { Id = 55, SectorId = 44, Name = "Clothing" },
                 new SectorModel { Id = 56, SectorId = 45, Name = "Textile" },
                 new SectorModel { Id = 57, SectorId = 8, Name = "Wood" },
                 new SectorModel { Id = 58, SectorId = 337, Name = "Other (Wood)" },
                 new SectorModel { Id = 59, SectorId = 51, Name = "Wooden building materials" },
                 new SectorModel { Id = 60, SectorId = 47, Name = "Wooden houses" },
                 new SectorModel { Id = 61, SectorId = 3, Name = "Other" },
                 new SectorModel { Id = 62, SectorId = 37, Name = "Creative industries" },
                 new SectorModel { Id = 63, SectorId = 29, Name = "Energy technology" },
                 new SectorModel { Id = 64, SectorId = 33, Name = "Environment" },
                 new SectorModel { Id = 65, SectorId = 2, Name = "Service" },
                 new SectorModel { Id = 66, SectorId = 25, Name = "Business services" },
                 new SectorModel { Id = 67, SectorId = 35, Name = "Engineering" },
                 new SectorModel { Id = 68, SectorId = 28, Name = "Information Technology and Telecommunications" },
                 new SectorModel { Id = 69, SectorId = 581, Name = "Data processing, Web portals, E-marketing" },
                 new SectorModel { Id = 70, SectorId = 576, Name = "Programming, Consultancy" },
                 new SectorModel { Id = 71, SectorId = 121, Name = "Software, Hardware" },
                 new SectorModel { Id = 72, SectorId = 122, Name = "Telecommunications" },
                 new SectorModel { Id = 73, SectorId = 22, Name = "Tourism" },
                 new SectorModel { Id = 74, SectorId = 141, Name = "Translation services" },
                 new SectorModel { Id = 75, SectorId = 21, Name = "Transport and Logistics" },
                 new SectorModel { Id = 76, SectorId = 111, Name = "Air" },
                 new SectorModel { Id = 77, SectorId = 114, Name = "Rail" },
                 new SectorModel { Id = 78, SectorId = 112, Name = "Road" },
                 new SectorModel { Id = 79, SectorId = 113, Name = "Water" }
            );
        }

        public DbSet<UserModel> UsersDb { get; set; }

        public DbSet<SectorModel> SectorsDb { get; set; }
        public DbSet<User_Sector_Model> User_Sectors { get; set; }
    }
}
