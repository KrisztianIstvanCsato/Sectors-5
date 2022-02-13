using Sectors.Shared;
using Sectors.Shared.Dtos;

namespace Sectors.Client.Services
{
    public interface IApiService
    {
        Task<List<SectorDto>> GetSectors();
        Task<UserDto> GetUserByName(string name);
        Task<int[]> GetSectorIdCollectionByUserName(string userName);
        Task<UserDto> UserOperation(string OriginalNameInput, UserDto CurrentUser, List<SectorDto> SelectedSectors);
        Task<UserDto> CreateUser(UserDto userDto);
        Task<UserDto> UpdateUser(string originalNameInput, UserDto UserDto);
        UserDto CreateCurrentUserSectorDtoSelection(UserDto UserDto, List<SectorDto> CurrentSectorSelection);
        Task<bool> FindNameInUse(string UserName);
    }
}
