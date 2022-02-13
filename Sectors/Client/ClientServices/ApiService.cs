using Sectors.Shared;
using Sectors.Shared.Dtos;
using Sectors.Shared.Models;
using System.Net.Http.Json;


namespace Sectors.Client.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;
        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<SectorDto>> GetSectors()
        {
            return await _httpClient.GetFromJsonAsync<List<SectorDto>>("api/sector/sectors");
        }

        public async Task<int[]> GetSectorIdCollectionByUserName(string userName)
        {
            return await _httpClient.GetFromJsonAsync<int[]>($"api/sector/usersector/{userName}");
        }

        public async Task<UserDto> GetUserByName(string name)
        {
            return await _httpClient.GetFromJsonAsync<UserDto>($"api/sector/{name}");
        }

        public async Task<UserDto> UserOperation(string OriginalNameInput, UserDto CurrentUser, List<SectorDto> SelectedSectors)
        {
            var UserDto = CreateCurrentUserSectorDtoSelection(CurrentUser, SelectedSectors);

            if (CurrentUser.UserId.Equals(0))
            {
                return await CreateUser(UserDto);
            }
            else
            {
                return await UpdateUser(OriginalNameInput, UserDto);
            }
        }

        public async Task<UserDto> CreateUser(UserDto UserDto)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/sector", UserDto);
            return await response.Content.ReadFromJsonAsync<UserDto>();
        }

        public async Task<UserDto> UpdateUser(string NameInput, UserDto UserDto)
        {
            var response = await _httpClient.PutAsJsonAsync($"/api/sector/{NameInput}", UserDto);
            return await response.Content.ReadFromJsonAsync<UserDto>();
        }

        public UserDto CreateCurrentUserSectorDtoSelection(UserDto UserDto, List<SectorDto> CurrentSectorSelection)
        {
            UserDto.Sectors = new List<UserSectorDto>();
            CurrentSectorSelection.ForEach(cs => UserDto.Sectors.Add(new UserSectorDto { UserId = UserDto.UserId, SectorId = cs.SectorId }));

            return UserDto;
        }

        public async Task<bool> FindNameInUse(string UserName)
        {
            var NewNameUser = await GetUserByName(UserName);
            return NewNameUser.UserId.Equals(0) ? true : false;
        }
    }
}
