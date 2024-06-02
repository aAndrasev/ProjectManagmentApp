using ProjectManagmentApp.Domain.Entities;

namespace ProjectManagmentApp.Application.Interfaces.Repositories
{
    public interface IActivityRepository
    {
        IQueryable<Activity> GetAllAsync();
        Task<Activity?> GetByIdAsync(int id);
        Task<Activity> CreateAsync(Activity activity);
        Task<Activity> UpdateAsync(Activity activity);
        Task<Activity> DeleteAsync(int id);
    }
}
