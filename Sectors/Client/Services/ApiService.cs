using Sectors.Shared;
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

        public async Task<SectorModel[]> GetSectors()
        {
            return await _httpClient.GetFromJsonAsync<SectorModel[]>("api/sector/sectors");
        }

        public async Task<int[]> GetSectorIdCollectionByUserId(int userId)
        {
            return await _httpClient.GetFromJsonAsync<int[]>($"api/sector/user_sector_relations/{userId}");
        }

        public async Task<UserModel> GetUserByName(string name)
        {
            var responseUser = await _httpClient.GetFromJsonAsync<UserModel>($"api/sector/{name}");

            if (responseUser != null)
                return responseUser;
            else
                return null;
        }

        public async Task<HttpResponseMessage> CreateUser(UserModel user)
        {
            Console.WriteLine($"-----------Creating user: {user.Name}----------");
            var result = await _httpClient.PostAsJsonAsync("api/sector", user);
            return result;
        }

        public async Task<HttpResponseMessage> UpdateUser(UserModel user)
        {
            Console.WriteLine($"Updating user: {user.Name}");
            var result = await _httpClient.PostAsJsonAsync($"api/sector/{user.Id}", user);
            return result;
        }
    }
}
