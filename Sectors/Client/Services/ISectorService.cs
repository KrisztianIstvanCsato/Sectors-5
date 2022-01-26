using Sectors.Shared;

namespace Sectors.Client.Services
{
    public interface ISectorService
    {
        event Action OnChange;
        List<UserModel> UserList { get; set; }
        List<SectorModel> SectorList { get; set; }
        UserModel User { get; set; }
        Task<List<UserModel>> GetUsersData();
        Task<List<SectorModel>> GetSectors();
        Task<List<SectorModel>> GetSectorsBySectorId(int sectorId);
        Task<List<User_Sector_Model>> GetRelatedSectorIdByUserId(int userId);
        Task<UserModel> GetOneUser(string name);

        Task<List<UserModel>> CreateUser(UserModel user);
        Task<List<UserModel>> UpdateUser(UserModel user);
    }
}
