using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Interfaces;
using ProjectManagmentApp.Domain.Entities;
using System.Data;

namespace ProjectManagmentApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly ILogger<ProjectsController> _logger;
        private readonly IProjectService _projectService;

        public ProjectsController(ILogger<ProjectsController> logger, IProjectService projectService)
        {
            _logger = logger;
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProjects()
        {
            var result = await _projectService.GetProjectsAsync();
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
        public async Task<IActionResult> CreateProject(Project project)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdProjectDto = await _projectService.CreateProjectAsync(project);
            if (createdProjectDto == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to create project");
            }

            return CreatedAtAction(nameof(GetProject), new { id = createdProjectDto.Id }, createdProjectDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProject(int id, Project project)
        {
            if (id != project.Id)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                await _projectService.UpdateProjectAsync(project);
            }
            catch (DBConcurrencyException)
            {
                return BadRequest();
            }
            return Ok(project);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProject(int id)
        {
            var deletedProject = await _projectService.DeleteProjectAsync(id);
            if (deletedProject == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}

