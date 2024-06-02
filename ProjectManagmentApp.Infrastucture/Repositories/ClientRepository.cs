using Microsoft.EntityFrameworkCore;
using ProjectManagmentApp.Application.Interfaces.Repositories;
using ProjectManagmentApp.Domain.Entities;

namespace ProjectManagmentApp.Infrastucture.Repositories
{
    public class ClientRepository: IClientRepository
    {
        private readonly ApplicationDbContext _context;


        public ClientRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }


        //******* CRUD METHODS ******//
        public IQueryable<Client> GetAllAsync()
        {
            return _context.Clients.OrderBy(x => x.Name);
        }
        public async Task<Client?> GetByIdAsync(int id)
        {
            return await _context.Clients.FindAsync(id);
        }

        public async Task<Client> CreateAsync(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            return client;
        }

        public async Task<Client> UpdateAsync(Client client)
        {
            _context.Entry(client).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return client;
        }

        public async Task<Client> DeleteAsync(int id)
        {
            {
                var client = await _context.Clients.FindAsync(id);
                if (client == null)
                {
                    return null;
                }

                _context.Clients.Remove(client);
                await _context.SaveChangesAsync();

                return client;
            }
        }
        //*************//


    }
}
