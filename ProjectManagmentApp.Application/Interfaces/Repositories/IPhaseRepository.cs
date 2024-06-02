using ProjectManagmentApp.Domain.Entities;

namespace ProjectManagmentApp.Application.Interfaces.Repositories
{
    public interface IPhaseRepository
    {
        IQueryable<Phase> GetAllAsync();
        Task<Phase?> GetByIdAsync(int id);
        Task<Phase> CreateAsync(Phase phase);
        Task<Phase> UpdateAsync(Phase phase);
        Task<Phase> DeleteAsync(int id);
    }
}
