using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sectors.Server.Data;
using Sectors.Shared;
using Sectors.Shared.Dtos;
using System.Net.Http.Json;
using Sectors.Server.Interfaces;
using Sectors.Shared.Models;
using System.Linq;

namespace Sectors.Server.Services
{
    public class Repository : IRepository
    {
        private readonly DataContext _dataContext;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;
        public Repository(DataContext context, 
            ILogger<Repository> logger, IMapper mapper)
        {
            _dataContext = context;
            _logger = logger;
            _mapper = mapper;
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

        public async Task<List<SectorDto>> GetSectorDtos()
        {
            _logger.LogInformation("Getting sector dtos");

            var Sectors = _dataContext.SectorsDb
                        .OrderBy(x => x.SectorId);

            return _mapper.Map<List<SectorDto>>(Sectors);
        }

        public async Task<User> GetUserByName(string userName)
        {
            _logger.LogInformation($"Getting user by name {userName}");

            var User = _dataContext.UsersDb
                                .Where(u => u.Name == userName)
                                .FirstOrDefault();
            if (User == null)
                return new User();

            User.Sectors = GetUserSectorsByUserId(User.UserId);

            return User;
        }

        public async Task<UserDto> GetUserDtoByName(string userName)
        {
            _logger.LogInformation($"Getting user dto by name {userName}");

            return _mapper.Map<UserDto>(await GetUserByName(userName));
        }

        public List<UserSector> GetUserSectorsByUserId(int userId)
        {
            _logger.LogInformation($"Getting UserSector list by user id {userId}");

            return _dataContext.UserSectorsDb
                                .Where(us => us.UserId == userId)
                                .ToList();
        }

        public async Task<UserDto> CreateUser(UserDto UserDto)
        {
            _logger.LogInformation($"Creating user in service: {UserDto.Name}");

            Add(_mapper.Map<User>(UserDto));

            await Save();

            return UserDto;
        }

        public async Task<UserDto> UpdateUser(string InputName, UserDto UserDto)
        {
            _logger.LogInformation($"Updating user in service: {UserDto.Name}");

            var ModifiedUser = _mapper.Map<User>(UserDto);

            var DbUserInUse = _dataContext.Find<User>((await GetUserByName(InputName)).UserId);
            _dataContext.Entry(DbUserInUse).State = EntityState.Modified;

            _dataContext.RemoveRange(DbUserInUse.Sectors.Except(ModifiedUser.Sectors));

            DbUserInUse.Name = ModifiedUser.Name;
            DbUserInUse.Sectors = ModifiedUser.Sectors;

            Update(DbUserInUse);

            await Save();

            return UserDto;
        }
    }
}
