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
        public async Task<ActionResult<SectorModel[]>> GetSectors()
        {
            try
            {
                var result  = await _api.GetSectors();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {ex.Message}");
            }
        }

        [HttpGet("user_sector_relations/{userId}")]
        public async Task<ActionResult<int[]>> GetRelatedSectorIdByUserId(int userId)
        {
            try
            {
                var result = await _api.GetSectorIdCollectionByUserId(userId);
                
                if (result == null)
                    return new int[0];

                return Ok(result);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {ex.Message}");
            }
        }

        [HttpGet("{userName}")]
        public async Task<ActionResult<UserModel>> GetSingleUser(string userName)
        {
            try
            {
                var result = await _api.GetUserByName(userName);

                if (result == null) return new UserModel();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<UserModel>> PostSingleUser(UserModel user)
        {
            try
            {
                //Post request
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Database Failure: {ex.Message}");
            }
            return BadRequest();
        }
    }
}
