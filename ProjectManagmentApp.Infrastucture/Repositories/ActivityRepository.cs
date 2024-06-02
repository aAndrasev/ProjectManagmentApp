using Microsoft.EntityFrameworkCore;
using ProjectManagmentApp.Application.Interfaces.Repositories;
using ProjectManagmentApp.Domain.Entities;

namespace ProjectManagmentApp.Infrastucture.Repositories
{
    public class ActivityRepository: IActivityRepository
    {
        private readonly ApplicationDbContext _context;


        public ActivityRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }


        //******* CRUD METHODS ******//
        public IQueryable<Activity> GetAllAsync()
        {
            return _context.Activities.OrderBy(x => x.Name);
        }
        public async Task<Activity?> GetByIdAsync(int id)
        {
            return await _context.Activities.FindAsync(id);
        }

        public async Task<Activity> CreateAsync(Activity activity)
        {
            _context.Activities.Add(activity);
            await _context.SaveChangesAsync();
            return activity;
        }

        public async Task<Activity> UpdateAsync(Activity activity)
        {
            _context.Entry(activity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return activity;
        }

        public async Task<Activity> DeleteAsync(int id)
        {
            {
                var activity = await _context.Activities.FindAsync(id);
                if (activity == null)
                {
                    return null;
                }

                _context.Activities.Remove(activity);
                await _context.SaveChangesAsync();

                return activity;
            }
        }
        //*************//


    }
}
