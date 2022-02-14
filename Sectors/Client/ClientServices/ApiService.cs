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

        public async Task<UserDto> GetUserByName(string name)
        {
            return await _httpClient.GetFromJsonAsync<UserDto>($"api/sector/{name}");
        }

        public async Task<UserDto> SaveUser(UserDto userDto)
        {
            HttpResponseMessage? response = await _httpClient.PostAsJsonAsync("/api/sector", userDto);
            return await response.Content.ReadFromJsonAsync<UserDto>();
        }
    }
}
