using Microsoft.AspNetCore.Mvc;
using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Dtos.Requests;
using ProjectManagmentApp.Application.Interfaces;
using ProjectManagmentApp.Infrastucture.Services;

namespace ProjectManagmentApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResearchersController : ControllerBase
    {
        private readonly ILogger<ResearchersController> _logger;
        private readonly IResearcherService _researcherService;
        private readonly IResearcherRoleService _researcherRoleService;

        public ResearchersController(ILogger<ResearchersController> logger, IResearcherService researcherService, IResearcherRoleService researcherRoleService)
        {
            _logger = logger;
            _researcherService = researcherService;
            _researcherRoleService = researcherRoleService;
        }



        //******* CRUD METHODS *********//

        [HttpPost("GetAll")]
        public async Task<IActionResult> GetResearchers(GetResearchersRequest request)
        {
            var result = await _researcherService.GetResearchersAsync(request);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetResearcher(int id)
        {
            var result = await _researcherService.GetResearcherAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateResearcher(ResearcherDTO researcherDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdResearcherDto = await _researcherService.CreateResearcherAsync(researcherDTO);

            return Ok(createdResearcherDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateResearcher(int id, ResearcherDTO researcherDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedResearcherDto = await _researcherService.UpdateResearcherAsync(id, researcherDTO);

            if (updatedResearcherDto == null)
            {
                return NotFound();
            }

            return Ok(updatedResearcherDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResearcher(int id)
        {
            var deletedResearcher = await _researcherService.DeleteResearcherAsync(id);
            if (deletedResearcher == null)
            {
                return NotFound();
            }

            return NoContent();
        }
        //****************//

        [HttpGet("GetResearcherRoles")]
        public async Task<IActionResult> GetProjectStatuses()
        {
            var result = await _researcherRoleService.GetResearcherRolesAsync();
            return Ok(result);
        }
    }
}
