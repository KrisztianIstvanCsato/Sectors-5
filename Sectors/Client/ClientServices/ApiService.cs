using Sectors.Shared;
using Sectors.Shared.Dtos;
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
            if (responseUser != null)
                return responseUser;
            else
                return null;
        }

        public async Task CreateUser(UserDto user, List<SectorDto> selectedSectors)
        {
            user = CreateCurrentSelection(user, selectedSectors);
            await _httpClient.PostAsJsonAsync("/api/sector", user);
        }

        public async Task UpdateUser(UserDto user, List<SectorDto> selectedSectors)
        {
            user = CreateCurrentSelection(user, selectedSectors);
            await _httpClient.PutAsJsonAsync($"/api/sector/{user.Name}", user);
        }

        public UserDto CreateCurrentSelection(UserDto userDto, List<SectorDto> CurrentSectorSelection)
        {
            userDto.Sectors = new List<UserSectorDto>();
            CurrentSectorSelection.ForEach(cs => userDto.Sectors.Add(new UserSectorDto { UserName = userDto.Name, SectorId = cs.SectorId }));

            return userDto;
        }
    }
}
