using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectManagmentApp.Application.Interfaces;

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
        }
    }

