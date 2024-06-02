using ProjectManagmentApp.Application.Dtos;

namespace ProjectManagmentApp.Application.Interfaces
{
    public interface IProjectStatusService
    {
        Task<List<ProjectStatusDTO>> GetProjectStatusesAsync();
    }
}
