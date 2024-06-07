using Microsoft.EntityFrameworkCore;
using ProjectManagmentApp.Application.Interfaces.Repositories;
using ProjectManagmentApp.Domain.Entities;

namespace ProjectManagmentApp.Infrastucture.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _context;


        public ProjectRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }


        //******* CRUD METHODS ******//
        public IQueryable<Project> GetAllAsync()
        {
            return _context.Projects.OrderBy(x => x.Name);
        }
        public async Task<Project?> GetByIdAsync(int id)
        {
            return await _context.Projects
                .Include(r => r.ProjectStatus)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<Project> CreateAsync(Project project)
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();
            return project;
        }

        public async Task<Project> UpdateAsync(Project project)
        {
            _context.Entry(project).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return project;
        }

        public async Task DeleteAsync(int id)
        {

            var project = await _context.Projects.FindAsync(id);
            if (project == null)
            {
                return;
            }

            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();

        }
        //*************//


    }
}
