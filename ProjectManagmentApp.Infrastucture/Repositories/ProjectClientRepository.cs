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

        public async Task<ProjectClient> CreateAsync(ProjectClient projectClient)
        {
            _context.ProjectClients.Add(projectClient);
            await _context.SaveChangesAsync();
            return projectClient;
        }

        public async Task<ProjectClient> UpdateAsync(ProjectClient projectClient)
        {
            _context.Entry(projectClient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return projectClient;
        }

        public async Task DeleteAsync(int projectId, int clientId)
        {

            var projectClient = await _context.ProjectClients.FirstOrDefaultAsync(x => x.ClientId == clientId && x.ProjectId == projectId);
            if (projectClient == null)
            {
                return;
            }

            _context.ProjectClients.Remove(projectClient);
            await _context.SaveChangesAsync();
        }
    }
    
}
