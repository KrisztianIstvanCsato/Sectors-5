using Sectors.Shared.Dtos;

namespace Sectors.Client.Services
{
    public interface IApiService
    {
        Task<List<SectorDto>> GetSectors();
        Task<UserDto> GetUserByName(string name);
        Task<int[]> GetSectorIdCollectionByUserName(string userName);

        Task CreateUser(UserDto user, List<UserSectorDto> CurrentlySelectedSectors);
        Task UpdateUser(UserDto user, List<UserSectorDto> CurrentlySelectedSectors);
    }
}
