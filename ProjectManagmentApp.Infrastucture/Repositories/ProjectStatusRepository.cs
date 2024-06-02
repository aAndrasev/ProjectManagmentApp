using ProjectManagmentApp.Application.Interfaces.Repositories;
using ProjectManagmentApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
