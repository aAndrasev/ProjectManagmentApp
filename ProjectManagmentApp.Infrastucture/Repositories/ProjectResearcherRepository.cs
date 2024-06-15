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
    public class ProjectResearcherRepository : IProjectResearcherRepository
    {
        private readonly ApplicationDbContext _context;


        public ProjectResearcherRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        
        public IQueryable<ProjectResearcher> GetAllAsync()
        {
            return _context.ProjectResearchers;
        }

        public async Task<ProjectResearcher> CreateAsync(ProjectResearcher projectResearcher)
        {
            _context.ProjectResearchers.Add(projectResearcher);
            await _context.SaveChangesAsync();
            return projectResearcher;
        }

        public async Task<ProjectResearcher> UpdateAsync(ProjectResearcher projectResearcher)
        {
            _context.Entry(projectResearcher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return projectResearcher;
        }

        public async Task DeleteAsync(int projectId, int researcherId)
        {

            var projectResearcher = await _context.ProjectResearchers.FirstOrDefaultAsync(x => x.ResearcherId == researcherId && x.ProjectId == projectId);
            if (projectResearcher == null)
            {
                return;
            }

            _context.ProjectResearchers.Remove(projectResearcher);
            await _context.SaveChangesAsync();

        }
    }


}
