using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Interfaces;
using ProjectManagmentApp.Application.Interfaces.Repositories;

namespace ProjectManagmentApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResearchersController : ControllerBase
    {
        private readonly ILogger<ResearchersController> _logger;
        private readonly IResearcherService _researcherService;

        public ResearchersController(ILogger<ResearchersController> logger, IResearcherService researcherService)
        {
            _logger = logger;
            _researcherService = researcherService;
        }



        //******* CRUD METHODS *********//

        [HttpGet]
        public async Task<IActionResult> GetResearchers()
        {
            var result = await _researcherService.GetResearchersAsync();
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


    }
}
