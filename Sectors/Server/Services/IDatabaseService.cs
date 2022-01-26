using Sectors.Shared;

namespace Sectors.Server.Services
{
    public interface IDatabaseService
    {
        List<SectorModel> SectorList { get; set; }
        List<UserModel> UserList { get; set; }
        Task<List<SectorModel>> GetSectorData();
        Task<List<UserModel>> GetUserData();
        Task<UserModel> GetUserInfo(int id);
        Task<UserModel> CreateUser(UserModel user);
        Task<UserModel> UpdateUser(UserModel user, int id);
    }
}
