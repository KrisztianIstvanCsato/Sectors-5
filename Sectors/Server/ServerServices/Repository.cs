using AutoMapper;
using Sectors.Server.Data;
using Sectors.Shared;
using Sectors.Shared.Dtos;
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

        public List<SectorDto> GetSectorDtos()
        {
            _logger.LogInformation("Getting sector dtos");

            var sectors = _dataContext.Sector
                        .OrderBy(x => x.SectorId);

            return OrganizeSectorListHierarchy(_mapper.Map<List<SectorDto>>(sectors));
        }

        public UserDto GetUserDtoByName(string userName)
        {
            _logger.LogInformation($"Getting user dto by name {userName}");

            var user = _dataContext.User
                                .Where(u => u.Name == userName)
                                .FirstOrDefault();
            if (user == null)
            {
                return new UserDto { Name = userName };
            }

            var userDto = _mapper.Map<UserDto>(user);

            userDto.SectorIds = GetUserSectorsByUserId(user.UserId);

            return userDto;
        }

        public List<int> GetUserSectorsByUserId(int userId)
        {
            _logger.LogInformation($"Getting UserSector list by user id {userId}");

            return _dataContext.UserSector
                                .Where(us => us.UserId == userId)
                                .Select(us => us.SectorId)
                                .ToList();
        }

        public async Task<UserDto> SaveUser(UserDto userDto)
        {
            _logger.LogInformation($"Updating user in service: {userDto.Name}");

            var userById = _dataContext.User.FirstOrDefault(u => u.UserId == userDto.UserId);
            var userByName = _dataContext.User.FirstOrDefault(u => u.Name == userDto.Name);

            if (userById == null)
            {
                userById = new User { Name = userDto.Name };
                Add(userById);
                await Save();
            }
            else
            {
                if (userByName == null)
                {
                    userById.Name = userDto.Name;
                }
                Update(userById);
                await Save();

                var dbSectorIds = _dataContext.UserSector
                                    .Where(us => us.UserId == userById.UserId)
                                    .Select(si => si.SectorId)
                                    .ToList();

                if (!dbSectorIds.SequenceEqual(userDto.SectorIds))
                {
                    var idsToDelete = dbSectorIds
                                    .Except(userDto.SectorIds)
                                    .ToList();

                    var idsToAdd = userDto.SectorIds
                                            .Except(dbSectorIds)
                                            .ToList();

                    var userSectorToDelete = _dataContext.UserSector
                                                .Where(q => idsToDelete.Contains(q.SectorId))
                                                .ToList();

                    _dataContext.UserSector.RemoveRange(userSectorToDelete);

                    _dataContext.UserSector.AddRange(
                            idsToAdd.Select(us => new UserSector
                            {
                                UserId = userById.UserId,
                                SectorId = us
                            }));

                    await Save();
                }
            }

            return userDto;
        }

        private List<SectorDto> OrganizeSectorListHierarchy(List<SectorDto> sectorDtos)
        {
            _logger.LogInformation("Finding hierarchy for sector dtos");

            var orderedList = new List<SectorDto> { new SectorDto() }; // Seeding object with defult SectorId == 0
            var index = 0;

            while (orderedList.Count < sectorDtos.Count)
            {
                var item = orderedList[index];

                var temporaryList = sectorDtos
                    .Where(p => p.Parent.Equals(item.SectorId))
                    .OrderBy(p => p.Name)
                    .ToList();

                if (temporaryList.Count > 0)
                {
                    orderedList.InsertRange(index + 1, temporaryList);
                }
                index++;
            }
            return orderedList.Where(s => s.SectorId != 0).ToList();
        }
    }
}
