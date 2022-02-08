using Microsoft.AspNetCore.Mvc;
using Sectors.Server.Interfaces;
using Sectors.Server.Services;
using Sectors.Shared;
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
                var result = await _repositoryService.GetUserDtoByName(userName);

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
                return await _repositoryService.CreateUser(user);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure(CreateSingleUser): {ex.Message}");
            }
            return BadRequest($"Posting user {user.Name} failed");
        }

        [HttpPut("{name}")]
        public async Task<ActionResult<UserDto>> UpdateSingleUser(string name, UserDto userDto)
        {
            try
            {
                var test = await _repositoryService.UpdateUser(name, userDto);
                return test;
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure(CreateSingleUser): {ex.Message}");
            }
            return BadRequest($"Posting user {userDto.Name} failed");
        }
    }
}
