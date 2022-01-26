using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sectors.Server.Data;
using Sectors.Shared;

namespace Sectors.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectorController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public SectorController(DataContext context)
        {
            _dataContext = context;
        }

        [HttpGet("sectors")]
        public async Task<IActionResult> GetSectors() => 
            Ok(await _dataContext
                .SectorsDb
                .ToListAsync());     //   THIS SHOULD BE A SERVICE!!! --> Services/DatabaseService

        [HttpGet("users")]
        public async Task<IActionResult> GetUsers() => 
            Ok(await _dataContext
                .UsersDb
                .ToListAsync());     //   THIS SHOULD BE A SERVICE!!! --> Services/DatabaseService

        [HttpGet("user_sector_relations/{userId}")]
        public async Task<IActionResult> GetRelatedSectorIdByUserId(int userId) => 
            Ok(await _dataContext
                .User_Sectors
                .Where(x => x.UserId == userId)
                .ToListAsync());     //   THIS SHOULD BE A SERVICE!!! --> Services/DatabaseService

        [HttpGet("{name}")]
        public async Task<IActionResult> GetSingleUser(string name)
        {
            var user = await _dataContext
                .UsersDb
                .FirstOrDefaultAsync(u => u.Name == name);          //   THIS SHOULD BE A SERVICE!!! --> Services/DatabaseService
            if (user == null)
                return NotFound("User not found");

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserModel user)
        {
            _dataContext.UsersDb.Add(user);
            await _dataContext.SaveChangesAsync();          //   THIS SHOULD BE A SERVICE!!! --> Services/DatabaseService

            return Ok(await GetUsers());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(UserModel user)
        {
            var dbUser = await _dataContext.UsersDb
                .FirstOrDefaultAsync(h => h.Id == user.Id);
            if (dbUser == null)
                return NotFound("No such user");           //   THIS SHOULD BE A SERVICE!!! --> Services/DatabaseService

            dbUser.Name = user.Name;
            dbUser.Agreed = user.Agreed;

            await _dataContext.SaveChangesAsync();

            return Ok(await GetUsers());
        }
    }
}
