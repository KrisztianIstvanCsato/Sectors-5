using Sectors.Shared;

namespace Sectors.Client.Services
{
    public interface IApiService
    {
        Task<Sector[]> GetSectors();
        Task<User> GetUserByName(string name);
        Task<int[]> GetSectorIdCollectionByUserId(int userId);

        Task<HttpResponseMessage> CreateUser(User user);
        Task<HttpResponseMessage> UpdateUser(User user);
    }
}
