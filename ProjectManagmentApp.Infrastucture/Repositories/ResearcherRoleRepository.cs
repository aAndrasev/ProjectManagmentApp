using ProjectManagmentApp.Application.Interfaces.Repositories;
using ProjectManagmentApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Infrastucture.Repositories
{
    public class ResearcherRoleRepository : IResearcherRoleRepository
    {
        private readonly ApplicationDbContext _context;


        public ResearcherRoleRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public IQueryable<ResearcherRole> GetAllAsync()
        {
            return _context.ResearcherRoles;
        }
    }
}
