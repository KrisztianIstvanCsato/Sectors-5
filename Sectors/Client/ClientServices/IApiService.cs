using Sectors.Shared;
using Sectors.Shared.Dtos;

namespace Sectors.Client.Services
{
    public interface IApiService
    {
        Task<List<SectorDto>> GetSectors();
        Task<UserDto> GetUserByName(string name);
        Task<int[]> GetSectorIdCollectionByUserName(string userName);
        Task<UserDto> CreateUser(UserDto userDto, List<SectorDto> selectedSectors);
        Task<UserDto> UpdateUser(string originalNameInput, UserDto userDto, List<SectorDto>SelectedSectors);
        UserDto CreateCurrentSelection(UserDto userDto, List<SectorDto> CurrentSectorSelection);
    }
}
