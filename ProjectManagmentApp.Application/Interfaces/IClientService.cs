using ProjectManagmentApp.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagmentApp.Application.Interfaces
{
    public interface IClientService
    {
        Task<List<ClientDTO>> GetClientsAsync();
        Task<ClientDTO> GetClientAsync(int id);
        Task<ClientDTO> CreateClientAsync(ClientDTO clientDTO);
        Task<ClientDTO> UpdateClientAsync(int id, ClientDTO clientDTO);
        Task<ClientDTO> DeleteClientAsync(int id);
    }
}
