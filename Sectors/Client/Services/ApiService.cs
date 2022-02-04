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

        public async Task CreateUser(UserDto user, List<UserSectorDto> SelectedSectors)
        {
            Console.WriteLine($"-----------Creating user: {user.Agreed}-{user.Name}--------");
            await _httpClient.PostAsJsonAsync("/api/sector", user);
            await _httpClient.PostAsJsonAsync("/api/sector/userSector", SelectedSectors);
        }

        public async Task UpdateUser(UserDto user, List<UserSectorDto> SelectedSectors)
        {
            Console.WriteLine($"Updating user: {user.Name}");
            await _httpClient.PostAsJsonAsync($"/api/sector/{user.Name}", user);
        }
    }
}
