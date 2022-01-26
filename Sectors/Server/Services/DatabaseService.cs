using Microsoft.EntityFrameworkCore;
using Sectors.Server.Data;
using Sectors.Shared;

namespace Sectors.Server.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly DataContext _dataContext;

        public DatabaseService(DataContext context)
        {
            _dataContext = context;
        }
        public List<SectorModel> SectorList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<UserModel> UserList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task<UserModel> CreateUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SectorModel>> GetSectorData()
        {
            return await _dataContext.SectorsDb.ToListAsync();
        }

        public Task<List<UserModel>> GetUserData()
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetUserInfo(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> UpdateUser(UserModel user, int id)
        {
            throw new NotImplementedException();
        }
    }
}
