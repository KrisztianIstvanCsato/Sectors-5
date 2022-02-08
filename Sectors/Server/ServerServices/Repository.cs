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

        public async Task<List<SectorDto>> GetSectors()
        {
            _logger.LogInformation("Getting sectors");

            var query = _dataContext.SectorsDb
                        .OrderBy(x => x.SectorId);
            var mapped = _mapper.Map<List<SectorDto>>(query);
            return mapped;
        }

        public async Task<UserDto> GetUserDtoByName(string userName)
        {
            var User = GetUserByName(userName).Result;

            if (User == null)
                return new UserDto();

            var UserDto = _mapper.Map<UserDto>(User);

            UserDto.Sectors = await GetUserSectorCollectionByUserId(User.UserId);

            return UserDto;
        }

        public async Task<User> GetUserByName(string userName)
        {
            _logger.LogInformation($"Getting user by name {userName}");

            var User = _dataContext.UsersDb
                        .Where(u => u.Name == userName)
                        .FirstOrDefault();

            return User;
        }

        public async Task<List<UserSectorDto>> GetUserSectorCollectionByUserId(int userId)
        {
            _logger.LogInformation($"Getting sector id list by user id {userId}");

            var userSectors = _dataContext.UserSectorsDb
                            .Where(us => us.UserId == userId)
                            .ToList();

            var userSectorDto = _mapper.Map<List<UserSectorDto>>(userSectors);
            return userSectorDto;
        }

        public async Task<UserSector> GetUserSectorCollectionBySectorId(int sectorIs)
        {
            _logger.LogInformation($"Getting sector id list by user id {sectorIs}");

            var userSectors = _dataContext.UserSectorsDb
                            .Where(us => us.SectorId == sectorIs)
                            .FirstOrDefault();

            return userSectors;
        }

        public async Task<UserDto> CreateUser(UserDto UserDto)
        {
            _logger.LogInformation($"Creating user in service: {UserDto.Name}");

            var User = _mapper.Map<User>(UserDto);

            Add(User);

            await Save();

            UserDto = _mapper.Map<UserDto>(User);

            return UserDto;
        }

        public async Task<UserDto> UpdateUser(string InputName, UserDto UserDto)
        {
            _logger.LogInformation($"Updating user in service: {UserDto.Name}");

            //var OriginalUserDto = new UserDto();
            var OriginalUserDto = await GetUserDtoByName(InputName);

            var User = _dataContext.Set<User>()
                .Local
                .FirstOrDefault(entity => entity.UserId.Equals(UserDto.UserId));

            if (User != null)
            {
                // detach
                _dataContext.Entry(User).State = EntityState.Detached;
            }

            var UpdatedUser = _mapper.Map<User>(UserDto);

            _dataContext.Entry(UpdatedUser).State = EntityState.Modified;
            
            UpdatedUser.Name = UserDto.Name;

            var UpdatesSectors = _mapper.Map<List<UserSector>>(UserDto.Sectors);
            UpdatedUser.Sectors = UpdatesSectors;

            var SectorsToRemove = OriginalUserDto.Sectors.Except(UserDto.Sectors).ToList();

            Update(UpdatedUser);

            var sectors = new List<UserSector>();
            SectorsToRemove.ForEach(str => sectors.Add(GetUserSectorCollectionBySectorId(str.SectorId).Result));

            sectors.ForEach(str => Delete(str));

            await Save();

            return UserDto;
        }
    }
}
