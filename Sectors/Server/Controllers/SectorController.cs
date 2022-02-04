using Microsoft.AspNetCore.Mvc;
using Sectors.Server.Interfaces;
using Sectors.Server.Services;
using Sectors.Shared.Dtos;

namespace Sectors.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectorController : Controller
    {
        private readonly IRepository _repositoryService;
        private readonly ISeeder _seeder;

        public SectorController(IRepository api, ISeeder seeder)
        {
            _repositoryService = api;
            _seeder = seeder;
        }

        [HttpGet("sectors")]
        public async Task<IActionResult> GetSectors()
        {
            try
            {
                var result  = await _repositoryService.GetSectors();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure(GetSectors): {ex.Message}");
            }
        }

        //[HttpGet("usersector/{userName}")]
        //public async Task<IActionResult> GetRelatedSectorIdByUserId(string userName)
        //{
        //    try
        //    {
        //        var result = await _repositoryService.GetSectorIdCollectionByUserName(userName);
                
        //        if (result == null)
        //            return NotFound();

        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure(GetRelatedSectorIdByUserId): {ex.Message}");
        //    }
        //}

        [HttpGet("{userName}")]
        public async Task<ActionResult<UserDto>> GetSingleUser(string userName)
        {
            try
            {
                var result = await _repositoryService.GetUserByName(userName);

                if (result == null) return new UserDto();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure (GetSingleUser): {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> CreateSingleUser(UserDto user)
        {
            try
            {
                await _repositoryService.CreateUser(user);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure(CreateSingleUser): {ex.Message}");
            }
            return BadRequest($"Posting user {user.Name} failed");
        }

        //[HttpPost("/api/sector/userSector")]
        //public async Task<ActionResult<UserSectorDto[]>> CreateUserSectorSelection(List<UserSectorDto> userSectors)
        //{
        //    try
        //    {
        //        await _repositoryService.CreateUserSectorSelection(userSectors);
        //    }
        //    catch(Exception ex)
        //    {
        //        return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure(CreateUserSectorSelection): {ex.Message}");
        //    }
        //    return BadRequest($"Posting user-sector selection failed");
        //}
    }
}
