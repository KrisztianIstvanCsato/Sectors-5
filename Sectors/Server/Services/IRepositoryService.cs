using Sectors.Shared;

namespace Sectors.Server.Services
{
    public interface IRepositoryService
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        Task<bool> Save();
        Task<List<SectorModel>> GetSectors();
        Task<UserModel> GetUserByName(string name);
        Task<int[]> GetSectorIdListByUserId(int userId);
        Task<UserModel> CreateUser(UserModel user);
        Task<UserModel> UpdateUser(UserModel user, int id);
    }
}
