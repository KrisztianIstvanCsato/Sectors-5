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
        public async Task<IActionResult> GetSectorDtos()
        {
            try
            {
                return Ok(await _repositoryService.GetSectorDtos());
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure(GetSectors): {ex.Message}");
            }
        }

        [HttpGet("{userName}")]
        public async Task<ActionResult<UserDto>> GetUserDtoByName(string UserName)
        {
            try
            {
                return Ok(await _repositoryService.GetUserDtoByName(UserName));
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure (GetSingleUser): {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> CreateUser(UserDto User)
        {
            try
            {
                return await _repositoryService.CreateUser(User);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure(CreateSingleUser): {ex.Message}");
            }
            return BadRequest($"Posting user {User.Name} failed");
        }

        [HttpPut("{InputName}")]
        public async Task<ActionResult<UserDto>> UpdateUser(string InputName, UserDto UserDto)
        {
            try
            {
                return await _repositoryService.UpdateUser(InputName, UserDto);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure(CreateSingleUser): {ex.Message}");
            }
            return BadRequest($"Posting user {InputName} failed");
        }
    }
}
