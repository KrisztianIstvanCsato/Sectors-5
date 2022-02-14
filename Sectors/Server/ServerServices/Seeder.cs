using Sectors.Server.Data;
using Sectors.Server.Interfaces;
using Sectors.Shared;
using Sectors.Shared.Models;

namespace Sectors.Server.Services
{
    public class Seeder : ISeeder
    {
        private List<User> _userDtos = new List<User>
        {
            new User { UserId = 1, Name = "TestPerson1"},
            new User { UserId = 2, Name = "TestPerson2"}
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
            var _sectors = new SampleSectorSelector();
            return _sectors.ProcessSample();
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
