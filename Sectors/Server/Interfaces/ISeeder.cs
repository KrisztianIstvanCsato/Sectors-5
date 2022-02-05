using Sectors.Shared;
using Sectors.Shared.Models;

namespace Sectors.Server.Interfaces
{
    public interface ISeeder
    {
        List<Sector> GetSectors();
        List<User> GetUsers();
        List<UserSector> GetUserSectorSamples();
    }
}
