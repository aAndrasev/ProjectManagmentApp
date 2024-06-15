using Microsoft.EntityFrameworkCore;
using ProjectManagmentApp.Application.Interfaces.Repositories;
using ProjectManagmentApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Infrastucture.Repositories
{
    public class ProjectClientRepository: IProjectClientRepository
    {
        private readonly ApplicationDbContext _context;


        public ProjectClientRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public IQueryable<ProjectClient> GetAllAsync()
        {
            return _context.ProjectClients;
        }
    }
    
}
