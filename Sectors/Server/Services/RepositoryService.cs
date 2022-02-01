using Microsoft.EntityFrameworkCore;
using Sectors.Server.Data;
using Sectors.Shared;
using System.Net.Http.Json;

namespace Sectors.Server.Services
{
    public class RepositoryService : IRepositoryService
    {
        private readonly DataContext _dataContext;
        private readonly ILogger _logger;
        public RepositoryService(DataContext context, ILogger<RepositoryService> logger)
        {
            _dataContext = context;
            _logger = logger;
        }

        public void Add<T>(T entity) where T : class
        {
            _logger.LogInformation($"Adding object of type {entity.GetType()}");
            _dataContext.Add<T>(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _logger.LogInformation($"Deleting object of type {entity.GetType()}");
            _dataContext.Remove<T>(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _logger.LogInformation($"Updating object of type {entity.GetType()}");
            _dataContext.Update<T>(entity);
        }

        public async Task<bool> Save()
        {
            _logger.LogInformation("Saving changes");
            return (await _dataContext.SaveChangesAsync()) >= 0;
        }

        public async Task<SectorModel[]> GetSectors()
        {
            _logger.LogInformation("Getting sectors");

            var query = _dataContext.SectorsDb
                        .OrderBy(x => x.Id);

            return await query.ToArrayAsync();
        }

        public async Task<UserModel> GetUserByName(string name)
        {
            _logger.LogInformation($"Getting user by name {name}");

            var query = _dataContext.UsersDb
                        .FirstOrDefaultAsync(u => u.Name == name);
            return await query;
        }

        public async Task<int[]> GetSectorIdCollectionByUserId(int userId)
        {
            _logger.LogInformation($"Getting sector id list by user id {userId}");

            var query = _dataContext.User_Sectors
                        .Where(u => u.UserId == userId)
                        .Select(r => r.SectorId);

            return await query.ToArrayAsync();
        }

        //public async Task<List<UserModel>> CreateUser(UserModel user)
        //{
        //    Console.WriteLine("Creating user");
        //    var result = await _httpClient.PostAsJsonAsync("api/sector", user);
        //    UserList = await result.Content.ReadFromJsonAsync<List<UserModel>>();
        //    OnChange.Invoke();
        //    return UserList;
        //}

        //public async Task<List<UserModel>> UpdateUser(UserModel user)
        //{
        //    var result = await _httpClient.PostAsJsonAsync($"api/sector/{user.Id}", user);
        //    UserList = await result.Content.ReadFromJsonAsync<List<UserModel>>();
        //    OnChange.Invoke();
        //    return UserList;
        //}

        public async Task<UserModel> PostUser(UserModel user)
        {
            _logger.LogInformation($"Creating user in service: {user.Id}");

            Add(user);

            await Save();
            return user;
        }

        public Task<UserModel> PutUser(UserModel user, int id)
        {
            throw new NotImplementedException();
        }
    }
}
