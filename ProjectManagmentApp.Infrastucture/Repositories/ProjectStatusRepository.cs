using ProjectManagmentApp.Application.Interfaces.Repositories;
using ProjectManagmentApp.Domain.Entities;

namespace ProjectManagmentApp.Infrastucture.Repositories
{
    public class ProjectStatusRepository: IProjectStatusRepository
    {
        private readonly ApplicationDbContext _context;


        public ProjectStatusRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public IQueryable<ProjectStatus> GetAllAsync()
        {
            return _context.ProjectStatuses;
        }
    }
}
