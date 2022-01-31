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

        public List<UserModel> UserList { get; set; }
        public List<SectorModel> SectorList { get; set; }
        public UserModel User { get; set; }

        public event Action OnChange;

        public async Task<List<SectorModel>> GetSectors()
        {
            return await _httpClient.GetFromJsonAsync<List<SectorModel>>("api/sector/sectors");
        }

        public async Task<List<User_Sector_Model>> GetSectorIdListByUserId(int userId)
        {
            return await _httpClient.GetFromJsonAsync<List<User_Sector_Model>>($"api/sector/user_sector_relations/{userId}");
        }

        public async Task<UserModel?> GetUserByName(string name)
        {
            var responseUser = await _httpClient.GetFromJsonAsync<UserModel>($"api/sector/{name}");

            if (responseUser != null)
                return responseUser;
            else
                return null;
        }

        public async Task<List<UserModel>> CreateUser(UserModel user)
        {
            Console.WriteLine("Creating user");
            var result = await _httpClient.PostAsJsonAsync("api/sector", user);
            UserList = await result.Content.ReadFromJsonAsync<List<UserModel>>();
            OnChange.Invoke();
            return UserList;
        }

        public async Task<List<UserModel>> UpdateUser(UserModel user)
        {
            var result = await _httpClient.PostAsJsonAsync($"api/sector/{user.Id}", user);
            UserList = await result.Content.ReadFromJsonAsync<List<UserModel>>();
            OnChange.Invoke();
            return UserList;
        }
    }
}
