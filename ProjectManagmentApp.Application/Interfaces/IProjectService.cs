using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Dtos.Requests;

namespace ProjectManagmentApp.Application.Interfaces
{
    public interface IProjectService
    {
        Task<List<ProjectDTO>> GetProjectsAsync(GetProjectsRequest request);
        Task<ProjectDTO> GetProjectAsync(int id);
        Task<ProjectDTO> CreateProjectAsync(ProjectDTO projectDTO);
        Task<ProjectDTO> UpdateProjectAsync(int id, ProjectDTO projectDTO);
        Task DeleteProjectAsync(int id);
        Task<List<ProjectResearcherDTO>> GetProjectResearchersAsync();
        Task<List<ProjectClientDTO>> GetClientsProjectAsync();
    }
}
