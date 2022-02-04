using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sectors.Server.Data;
using Sectors.Shared;

namespace Sectors.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OldSectorController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public OldSectorController(DataContext context)
        {
            _dataContext = context;
        }

        [HttpGet("sectors")]
        public async Task<IActionResult> GetSectors() => 
            Ok(await _dataContext
                .SectorsDb
                .ToListAsync());     //   THIS SHOULD BE A SERVICE!!! --> Services/DatabaseService

        //[HttpGet("user_sector_relations/{userId}")]
        //public async Task<IActionResult> GetRelatedSectorIdByUserName(string userName) => 
        //    Ok(await _dataContext
        //        .UserSectorsDb
        //        .Where(x => x.UserName == userName)
        //        .ToListAsync());     //   THIS SHOULD BE A SERVICE!!! --> Services/DatabaseService

        [HttpGet("{name}")]
        public async Task<IActionResult> GetSingleUser(string name)
        {
            var user = await _dataContext
                .UsersDb
                .FirstOrDefaultAsync(u => u.Name == name);          //   THIS SHOULD BE A SERVICE!!! --> Services/DatabaseService
            if (user == null)
                return Ok(new User());

            return Ok(user);
        }

        //[HttpPost]
        //public async Task<IActionResult> CreateUser(UserModel user)
        //{
        //    _dataContext.UsersDb.Add(user);
        //    await _dataContext.SaveChangesAsync();          //   THIS SHOULD BE A SERVICE!!! --> Services/DatabaseService
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateUser(UserModel user)
        //{
        //    var dbUser = await _dataContext.UsersDb
        //        .FirstOrDefaultAsync(h => h.Id == user.Id);
        //    if (dbUser == null)
        //        return NotFound("No such user");           //   THIS SHOULD BE A SERVICE!!! --> Services/DatabaseService

        //    dbUser.Name = user.Name;
        //    dbUser.Agreed = user.Agreed;

        //    await _dataContext.SaveChangesAsync();
        //}
    }
}
