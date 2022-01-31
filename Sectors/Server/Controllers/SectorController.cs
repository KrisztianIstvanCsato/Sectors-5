using Microsoft.AspNetCore.Mvc;
using Sectors.Server.Services;
using Sectors.Shared;

namespace Sectors.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectorController : Controller
    {
        private readonly IRepositoryService _api;

        public SectorController(IRepositoryService api)
        {
            _api = api;
        }

        [HttpGet("sectors")]
        public async Task<ActionResult<SectorModel>> GetSectors()
        {
            try
            {
                var result  = await _api.GetSectors();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {ex}");
            }
        }

        [HttpGet("user_sector_relations/{userId}")]
        public async Task<IActionResult> GetRelatedSectorIdByUserId(int userId)
        {
            try
            {
                var result = await _api.GetSectorIdListByUserId(userId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {ex}");
            }
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<UserModel>> GetSingleUser(string userName)
        {
            try
            {
                var result = await _api.GetUserByName(userName);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {ex}");
            }
        }
    }
}
