using Sectors.Server.Interfaces;
using Sectors.Shared;
using Sectors.Shared.Models;

namespace Sectors.Server.Services
{
    public class Seeder : ISeeder
    {
        private List<Sector> _sectors = new List<Sector>
        {
            new Sector { SectorId = 1, Name = "Manufacturing" },
            new Sector { SectorId = 19, Name = "Construction materials" },
            new Sector { SectorId = 18, Name = "Electronics and Optics" },
            new Sector { SectorId = 6, Name = "Food and Beverage" },
            new Sector { SectorId = 342, Name = "Bakery & confectionery products" },
            new Sector { SectorId = 43, Name = "Beverages" },
            new Sector { SectorId = 42, Name = "Fish & fish products" },
            new Sector { SectorId = 40, Name = "Meat & meat products" },
            new Sector { SectorId = 39, Name = "Milk & dairy products" },
            new Sector { SectorId = 437, Name = "Other" },
            new Sector { SectorId = 378, Name = "Sweets & snack food" },
            new Sector { SectorId = 13, Name = "Furniture" },
            new Sector { SectorId = 389, Name = "Bathroom/sauna" },
            new Sector { SectorId = 385, Name = "Bedroom" },
            new Sector { SectorId = 390, Name = "Children’s room" },
            new Sector { SectorId = 98, Name = "Kitchen" },
            new Sector { SectorId = 101, Name = "Living room" },
            new Sector { SectorId = 392, Name = "Office" },
            new Sector { SectorId = 394, Name = "Other (Furniture)" },
            new Sector { SectorId = 341, Name = "Outdoor" },
            new Sector { SectorId = 99, Name = "Project furniture" },
            new Sector { SectorId = 12, Name = "Machinery" },
            new Sector { SectorId = 94, Name = "Machinery components" },
            new Sector { SectorId = 91, Name = "Machinery equipment/tools" },
            new Sector { SectorId = 224, Name = "Manufacture of machinery" },
            new Sector { SectorId = 97, Name = "Maritime" },
            new Sector { SectorId = 271, Name = "Aluminium and steel workboats" },
            new Sector { SectorId = 269, Name = "Boat/Yacht building" },
            new Sector { SectorId = 230, Name = "Ship repair and conversion" },
            new Sector { SectorId = 93, Name = "Metal structures" },
            new Sector { SectorId = 508, Name = "Other" },
            new Sector { SectorId = 227, Name = "Repair and maintenance service" },
            new Sector { SectorId = 11, Name = "Metalworking" },
            new Sector { SectorId = 67, Name = "Construction of metal structures" },
            new Sector { SectorId = 263, Name = "Houses and buildings" },
            new Sector { SectorId = 267, Name = "Metal products" },
            new Sector { SectorId = 542, Name = "Metal works" },
            new Sector { SectorId = 75, Name = "CNC-machining" },
            new Sector { SectorId = 62, Name = "Forgings, Fasteners" },
            new Sector { SectorId = 69, Name = "Gas, Plasma, Laser cutting" },
            new Sector { SectorId = 66, Name = "MIG, TIG, Aluminum welding" },
            new Sector { SectorId = 9, Name = "Plastic and Rubber" },
            new Sector { SectorId = 54, Name = "Packaging" },
            new Sector { SectorId = 556, Name = "Plastic goods" },
            new Sector { SectorId = 559, Name = "Plastic processing technology" },
            new Sector { SectorId = 55, Name = "Blowing" },
            new Sector { SectorId = 57, Name = "Moulding" },
            new Sector { SectorId = 53, Name = "Plastics welding and processing" },
            new Sector { SectorId = 560, Name = "Plastic profiles" },
            new Sector { SectorId = 5, Name = "Printing" },
            new Sector { SectorId = 148, Name = "Advertising" },
            new Sector { SectorId = 150, Name = "Book/Periodicals printing" },
            new Sector { SectorId = 145, Name = "Labelling and packaging printing" },
            new Sector { SectorId = 7, Name = "Textile and Clothing" },
            new Sector { SectorId = 44, Name = "Clothing" },
            new Sector { SectorId = 45, Name = "Textile" },
            new Sector { SectorId = 8, Name = "Wood" },
            new Sector { SectorId = 337, Name = "Other (Wood)" },
            new Sector { SectorId = 51, Name = "Wooden building materials" },
            new Sector { SectorId = 47, Name = "Wooden houses" },
            new Sector { SectorId = 3, Name = "Other" },
            new Sector { SectorId = 37, Name = "Creative industries" },
            new Sector { SectorId = 29, Name = "Energy technology" },
            new Sector { SectorId = 33, Name = "Environment" },
            new Sector { SectorId = 2, Name = "Service" },
            new Sector { SectorId = 25, Name = "Business services" },
            new Sector { SectorId = 35, Name = "Engineering" },
            new Sector { SectorId = 28, Name = "Information Technology and Telecommunications" },
            new Sector { SectorId = 581, Name = "Data processing, Web portals, E-marketing" },
            new Sector { SectorId = 576, Name = "Programming, Consultancy" },
            new Sector { SectorId = 121, Name = "Software, Hardware" },
            new Sector { SectorId = 122, Name = "Telecommunications" },
            new Sector { SectorId = 22, Name = "Tourism" },
            new Sector { SectorId = 141, Name = "Translation services" },
            new Sector { SectorId = 21, Name = "Transport and Logistics" },
            new Sector { SectorId = 111, Name = "Air" },
            new Sector { SectorId = 114, Name = "Rail" },
            new Sector { SectorId = 112, Name = "Road" },
            new Sector { SectorId = 113, Name = "Water" }
        };

        private List<User> _userDtos = new List<User>
        {
            new User { Id = 1, Name = "TestPerson1", Agreed = true },
            new User { Id = 2, Name = "TestPerson2", Agreed = true }
        };

        private List<UserSector> _userSectors = new List<UserSector>
        {
            new UserSector{ UserName = "TestPerson1", SectorId = 576 },
            new UserSector{ UserName = "TestPerson1", SectorId = 25 },
            new UserSector{ UserName = "TestPerson2", SectorId = 37 },
            new UserSector{ UserName = "TestPerson2", SectorId = 267 }
        };

        public List<Sector> GetSectors()
        {
            return _sectors;
        }

        public List<User> GetUsers()
        {
            return _userDtos;
        }

        public List<UserSector> GetUserSectorSamples()
        {
            return _userSectors;
        }
    }
}
