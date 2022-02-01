using Sectors.Shared;

namespace Sectors.Server.Services
{
    public interface IRepositoryService
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        Task<bool> Save();
        Task<Sector[]> GetSectors();
        Task<User> GetUserByName(string name);
        Task<int[]> GetSectorIdCollectionByUserId(int userId);
        Task<User> PostUser(User user);
        Task<User> PutUser(User user, int id);
    }
}
