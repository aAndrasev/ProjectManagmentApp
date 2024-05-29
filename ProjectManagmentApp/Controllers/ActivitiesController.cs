using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Interfaces;

namespace ProjectManagmentApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        private readonly ILogger<ActivitiesController> _logger;
        private readonly IActivityService _activityService;

        public ActivitiesController(ILogger<ActivitiesController> logger, IActivityService activityService)
        {
            _logger = logger;
            _activityService = activityService;
        }



        //******* CRUD METHODS *********//

        [HttpGet]
        public async Task<IActionResult> GetActivities()
        {
            var result = await _activityService.GetActivitiesAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetActivity(int id)
        {
            var result = await _activityService.GetActivityAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateActivity(ActivityDTO activityDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdActivityDto = await _activityService.CreateActivityAsync(activityDTO);

            return Ok(createdActivityDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateActivity(int id, ActivityDTO activityDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedActivityDto = await _activityService.UpdateActivityAsync(id, activityDTO);

            if (updatedActivityDto == null)
            {
                return NotFound();
            }

            return Ok(updatedActivityDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(int id)
        {
            var deletedClient = await _activityService.DeleteActivityAsync(id);
            if (deletedClient == null)
            {
                return NotFound();
            }

            return NoContent();
        }
        //****************//


    }
}
