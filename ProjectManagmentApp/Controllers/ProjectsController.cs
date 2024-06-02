using Microsoft.AspNetCore.Mvc;
using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Dtos.Requests;
using ProjectManagmentApp.Application.Interfaces;

namespace ProjectManagmentApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ILogger<ProjectsController> _logger;
        private readonly IProjectService _projectService;
        private readonly IProjectStatusService _projectStatusService;

        public ProjectsController(ILogger<ProjectsController> logger, IProjectService projectService, IProjectStatusService projectStatusService)
        {
            _logger = logger;
            _projectService = projectService;
            _projectStatusService = projectStatusService;
        }



        //******* CRUD METHODS *********//

        [HttpPost("GetAll")]
        public async Task<IActionResult> GetProjects([FromBody] GetProjectsRequest request)
            {
            var result = await _projectService.GetProjectsAsync(request);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProject(int id)
        {
            var result = await _projectService.GetProjectAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProject(ProjectDTO projectDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdProjectDto = await _projectService.CreateProjectAsync(projectDTO);

            return Ok(createdProjectDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProject(int id, ProjectDTO projectDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedProjectDto = await _projectService.UpdateProjectAsync(id, projectDTO);

            if (updatedProjectDto == null)
            {
                return NotFound();
            }

            return Ok(updatedProjectDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject(int id)
        {
            await _projectService.DeleteProjectAsync(id);
            return Ok();
        }
        //****************//

        [HttpGet("GetProjectStatuses")]
        public async Task<IActionResult> GetProjectStatuses()
        {
            var result = await _projectStatusService.GetProjectStatusesAsync();
            return Ok(result);
        }
    }
}

