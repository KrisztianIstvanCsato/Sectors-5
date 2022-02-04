using Sectors.Shared;
using Sectors.Shared.Dtos;

namespace Sectors.Server.Services
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        Task<bool> Save();
        Task<List<SectorDto>> GetSectors();
        Task<UserDto> GetUserByName(string name);
        Task<List<UserSectorDto>> GetUserSectorCollectionByUserName(string userName);
        Task<UserDto> CreateUser(UserDto user);
        //Task<List<UserSectorDto>> CreateUserSectorSelection(List<UserSectorDto> userSectors);
        Task<UserDto> UpdateUser(UserDto user, int id);
    }
}
