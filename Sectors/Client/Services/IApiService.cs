using Sectors.Shared;
using Sectors.Shared.Dtos;

namespace Sectors.Client.Services
{
    public interface IApiService
    {
        Task<List<SectorDto>> GetSectors();
        Task<UserDto> GetUserByName(string name);
        Task<int[]> GetSectorIdCollectionByUserName(string userName);

        Task CreateUser(UserDto user, List<SectorDto> selectedSectors);
        Task UpdateUser(UserDto user, List<SectorDto>SelectedSectors);
        UserDto CreateCurrentSelection(UserDto userDto, List<SectorDto> CurrentSectorSelection);
    }
}
