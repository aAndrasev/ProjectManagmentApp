using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Interfaces.Repositories;

namespace ProjectManagmentApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhasesController : ControllerBase
    {
        private readonly ILogger<PhasesController> _logger;
        private readonly IPhaseService _phaseService;

        public PhasesController(ILogger<PhasesController> logger, IPhaseService phaseService)
        {
            _logger = logger;
            _phaseService = phaseService;
        }



        //******* CRUD METHODS *********//

        [HttpGet]
        public async Task<IActionResult> GetPhases()
        {
            var result = await _phaseService.GetPhasesAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPhase(int id)
        {
            var result = await _phaseService.GetPhaseAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePhase(PhaseDTO phaseDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdPhaseDto = await _phaseService.CreatePhaseAsync(phaseDTO);

            return Ok(createdPhaseDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePhase(int id, PhaseDTO phaseDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedPhaseDto = await _phaseService.UpdatePhaseAsync(id, phaseDTO);

            if (updatedPhaseDto == null)
            {
                return NotFound();
            }

            return Ok(updatedPhaseDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhase(int id)
        {
            var deletedPhase = await _phaseService.DeletePhaseAsync(id);
            if (deletedPhase == null)
            {
                return NotFound();
            }

            return NoContent();
        }
        //****************//


    }
}
