using ProjectManagmentApp.Domain.Entities;

namespace ProjectManagmentApp.Application.Interfaces.Repositories
{
    public interface IClientRepository
    {
        IQueryable<Client> GetAllAsync();
        Task<Client?> GetByIdAsync(int id);
        Task<Client> CreateAsync(Client client);
        Task<Client> UpdateAsync(Client client);
        Task<Client> DeleteAsync(int id);
    }
}
