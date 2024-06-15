using ProjectManagmentApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Application.Interfaces.Repositories
{
    public interface IProjectResearcherRepository
    {
        IQueryable<ProjectResearcher> GetAllAsync();
        Task<ProjectResearcher> CreateAsync(ProjectResearcher projectResearcher);
        Task<ProjectResearcher> UpdateAsync(ProjectResearcher projectResearcher);
        Task DeleteAsync(int projectId, int researcherId);
    }
}
