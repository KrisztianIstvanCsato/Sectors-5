using Sectors.Shared;

namespace Sectors.Server.Interfaces
{
    public interface ISeeder
    {
        List<Sector> GetSectors();
        List<User> GetUsers();
    }
}
