using Microsoft.EntityFrameworkCore;
using ProjectManagmentApp.Application.Interfaces.Repositories;
using ProjectManagmentApp.Domain.Entities;

namespace ProjectManagmentApp.Infrastucture.Repositories
{
    public class PhaseRepository: IPhaseRepository
    {
        private readonly ApplicationDbContext _context;


        public PhaseRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }


        //******* CRUD METHODS ******//
        public IQueryable<Phase> GetAllAsync()
        {
            return _context.Phases.OrderBy(x => x.Name);
        }
        public async Task<Phase?> GetByIdAsync(int id)
        {
            return await _context.Phases.FindAsync(id);
        }

        public async Task<Phase> CreateAsync(Phase phase)
        {
            _context.Phases.Add(phase);
            await _context.SaveChangesAsync();
            return phase;
        }

        public async Task<Phase> UpdateAsync(Phase phase)
        {
            _context.Entry(phase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return phase;
        }

        public async Task<Phase> DeleteAsync(int id)
        {
            {
                var phase = await _context.Phases.FindAsync(id);
                if (phase == null)
                {
                    return null;
                }

                _context.Phases.Remove(phase);
                await _context.SaveChangesAsync();

                return phase;
            }
        }
        //*************//


    }
}
