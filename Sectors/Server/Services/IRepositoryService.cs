using Sectors.Shared;

namespace Sectors.Server.Services
{
    public interface IRepositoryService
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        Task<bool> Save();
        Task<SectorModel[]> GetSectors();
        Task<UserModel> GetUserByName(string name);
        Task<int[]> GetSectorIdCollectionByUserId(int userId);
        Task<UserModel> PostUser(UserModel user);
        Task<UserModel> PutUser(UserModel user, int id);
    }
}
