using ProjectManagmentApp.Domain.Entities;

namespace ProjectManagmentApp.Application.Interfaces.Repositories
{
    public interface IProjectRepository
    {
        IQueryable<Project> GetAllAsync();
        Task<Project?> GetByIdAsync(int id);
        Task<Project> CreateAsync(Project project);
        Task<Project> UpdateAsync(Project project); 
        Task DeleteAsync(int id);
    }
}
