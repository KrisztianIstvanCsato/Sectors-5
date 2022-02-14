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
        List<SectorDto> GetSectorDtos();
        UserDto GetUserDtoByName(string name);
        Task<UserDto> SaveUser(UserDto user);
    }
}
