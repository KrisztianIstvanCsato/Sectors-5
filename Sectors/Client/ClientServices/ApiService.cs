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
            var responseUser = await _httpClient.GetFromJsonAsync<UserDto>($"api/sector/{name}");

            Console.WriteLine("responseUser.Name = " + responseUser.Name);
            
            return responseUser;
        }

        public async Task<UserDto> CreateUser(UserDto userDto, List<SectorDto> selectedSectors)
        {
            userDto = CreateCurrentSelection(userDto, selectedSectors);
            var response = await _httpClient.PostAsJsonAsync("/api/sector", userDto);
            userDto = await response.Content.ReadFromJsonAsync<UserDto>();

            return userDto;
        }

        public async Task<UserDto> UpdateUser(string OriginalNameInput, UserDto userDto, List<SectorDto> selectedSectors)
        {
            var user = CreateCurrentSelection(userDto, selectedSectors);
            var response = await _httpClient.PutAsJsonAsync($"/api/sector/{OriginalNameInput}", user);
            userDto = await response.Content.ReadFromJsonAsync<UserDto>();

            return userDto;
        }

        public UserDto CreateCurrentSelection(UserDto userDto, List<SectorDto> CurrentSectorSelection)
        {
            userDto.Sectors = new List<UserSectorDto>();
            CurrentSectorSelection.ForEach(cs => userDto.Sectors.Add(new UserSectorDto { UserId = userDto.UserId, SectorId = cs.SectorId }));

            return userDto;
        }
    }
}
