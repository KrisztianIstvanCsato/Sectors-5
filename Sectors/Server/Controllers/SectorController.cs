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
        public IActionResult GetSectorDtos()
        {
            try
            {
                return Ok(_repositoryService.GetSectorDtos());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure(GetSectors): {ex.Message}");
            }
        }

        [HttpGet("{userName}")]
        public ActionResult<UserDto> GetUserDtoByName(string userName)
        {
            try
            {
                return Ok(_repositoryService.GetUserDtoByName(userName));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure (GetSingleUser): {ex.Message}");
            }
        }


        [HttpPost]
        public async Task<ActionResult<UserDto>> SaveUser(UserDto userDto)
        {
            try
            {
                return await _repositoryService.SaveUser(userDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure(CreateSingleUser): {ex.Message}");
            }
        }
    }
}
