using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sectors.Server.Data;
using Sectors.Shared;
using Sectors.Shared.Dtos;
using System.Net.Http.Json;
using Sectors.Server.Interfaces;
using Sectors.Shared.Models;

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

        public async Task<UserDto> GetUserByName(string userName)
        {
            _logger.LogInformation($"Getting user by name {userName}");
            
            var userSectorDtos = await GetUserSectorCollectionByUserName(userName);

            if(userSectorDtos == null)
                return null;

            var user = _dataContext.UsersDb
                        .Where(u => u.Name == userName)
                        .FirstOrDefault();
            var UserDto = new UserDto();
            UserDto = _mapper.Map<UserDto>(user);

            return UserDto;
        }

        public async Task<List<UserSectorDto>> GetUserSectorCollectionByUserName(string userName)
        {
            var userSectors = _dataContext.UserSectorsDb
                            .Where(us => us.UserName == userName)
                            .ToList();

            var userSectorDto = _mapper.Map<List<UserSectorDto>>(userSectors);
            return userSectorDto;
        }

        public async Task<UserSectorDto[]> GetSectorIdCollectionByUserName(string userName)
        {
            _logger.LogInformation($"Getting sector id list by user id {userName}");

            var query = _dataContext.UserSectorsDb
                        .Where(u => u.UserName == userName)
                        .ToArray();
            var mapped = _mapper.Map<UserSectorDto[]>(query);
            return mapped;
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

        public async Task<UserDto> CreateUser(UserDto UserDto)
        {
            _logger.LogInformation($"Creating user in service: {UserDto.Name}");

            var User = new User();
            User = _mapper.Map<User>(UserDto);

            Add(User);

            await Save();

            return UserDto;
        }

        public async Task<UserDto> UpdateUser(UserDto UserDto)
        {
            _logger.LogInformation($"Updating user in service: {UserDto.Name}");

            var OldUser = _dataContext.UsersDb
                            .Where(u => u.Name == UserDto.Name)
                            .FirstOrDefault();
            if (OldUser == null)
                return null;


            var User = new User();
            User = _mapper.Map(UserDto, OldUser);

            Update(User);

            await Save();

            return UserDto;
        }

    }
}
