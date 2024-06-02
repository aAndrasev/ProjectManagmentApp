using ProjectManagmentApp.Domain.Entities;

namespace ProjectManagmentApp.Application.Interfaces.Repositories
{
    public interface IProjectStatusRepository
    {
        IQueryable<ProjectStatus> GetAllAsync();
    }
}
