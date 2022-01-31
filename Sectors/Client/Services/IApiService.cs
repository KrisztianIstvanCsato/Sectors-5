using Sectors.Shared;

namespace Sectors.Client.Services
{
    public interface IApiService
    {
        event Action OnChange;
        List<UserModel> UserList { get; set; }
        List<SectorModel> SectorList { get; set; }
        UserModel User { get; set; }

        Task<List<SectorModel>> GetSectors();
        Task<UserModel> GetUserByName(string name);
        Task<List<User_Sector_Model>> GetSectorIdListByUserId(int userId);

        Task<List<UserModel>> CreateUser(UserModel user);
        Task<List<UserModel>> UpdateUser(UserModel user);
    }
}
