using Microsoft.EntityFrameworkCore;
using ProjectManagmentApp.Application.Interfaces.Repositories;
using ProjectManagmentApp.Domain.Entities;

namespace ProjectManagmentApp.Infrastucture.Repositories
{
    public class ResearcherRepository: IResearcherRepository
    {
        private readonly ApplicationDbContext _context;


        public ResearcherRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }


        //******* CRUD METHODS ******//
        public IQueryable<Researcher> GetAllAsync()
        {
            return _context.Researchers.OrderBy(x => x.Name);
        }
        public async Task<Researcher?> GetByIdAsync(int id)
        {
            return await _context.Researchers
                .Include(r => r.ResearcherRole)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<Researcher> CreateAsync(Researcher researcher)
        {
            _context.Researchers.Add(researcher);
            await _context.SaveChangesAsync();
            return researcher;
        }

        public async Task<Researcher> UpdateAsync(Researcher researcher)
        {
            _context.Entry(researcher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return researcher;
        }

        public async Task<Researcher> DeleteAsync(int id)
        {
            {
                var researcher = await _context.Researchers.FindAsync(id);
                if (researcher == null)
                {
                    return null;
                }

                _context.Researchers.Remove(researcher);
                await _context.SaveChangesAsync();

                return researcher;
            }
        }
        //*************//


    }
}

