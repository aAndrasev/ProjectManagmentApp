using ProjectManagmentApp.Domain.Entities;

namespace ProjectManagmentApp.Application.Interfaces.Repositories
{
    public interface IResearcherRepository
    {
        IQueryable<Researcher> GetAllAsync();
        Task<Researcher?> GetByIdAsync(int id);
        Task<Researcher> CreateAsync(Researcher researcher);
        Task<Researcher> UpdateAsync(Researcher researcher);
        Task<Researcher> DeleteAsync(int id);
    }
}
