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
        Task<List<SectorDto>> GetSectorDtos();
        Task<UserDto> GetUserDtoByName(string Name);
        Task<UserDto> CreateUser(UserDto User);
        Task<UserDto> UpdateUser(string UserName, UserDto User);
    }
}
