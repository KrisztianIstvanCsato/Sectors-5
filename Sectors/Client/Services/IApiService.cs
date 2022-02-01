using Sectors.Shared;

namespace Sectors.Client.Services
{
    public interface IApiService
    {
        Task<SectorModel[]> GetSectors();
        Task<UserModel> GetUserByName(string name);
        Task<int[]> GetSectorIdCollectionByUserId(int userId);

        Task<HttpResponseMessage> CreateUser(UserModel user);
        Task<HttpResponseMessage> UpdateUser(UserModel user);
    }
}
