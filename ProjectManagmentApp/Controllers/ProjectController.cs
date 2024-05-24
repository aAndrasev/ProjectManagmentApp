using Microsoft.AspNetCore.Mvc;
using ProjectManagmentApp.Application.Interfaces;
using ProjectManagmentApp.Controllers;

namespace ProjectManagmentApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IProjectService _projectService;

        public ProjectController(ILogger<WeatherForecastController> logger, IProjectService projectService)
        {
            _logger = logger;
            _projectService = projectService;
        }
        
    }
}
