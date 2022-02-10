using Sectors.Server.Data;
using Sectors.Server.Interfaces;
using Sectors.Shared;
using Sectors.Shared.Models;

namespace Sectors.Server.Services
{
    public class Seeder : ISeeder
    {
        private List<Sector> _sectors = SampleSectorSelector.ProcessSample();

        private List<User> _userDtos = new List<User>
        {
            new User { UserId = 1, Name = "TestPerson1", Agreed = true },
            new User { UserId = 2, Name = "TestPerson2", Agreed = true }
        };

        private List<UserSector> _userSectors = new List<UserSector>
        {
            new UserSector{ UserId = 1, SectorId = 576 },
            new UserSector{ UserId = 1, SectorId = 25 },
            new UserSector{ UserId = 2, SectorId = 37 },
            new UserSector{ UserId = 2, SectorId = 267 }
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
