using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Dtos.Requests;

namespace ProjectManagmentApp.Application.Interfaces
{
    public interface IClientService
    {
        Task<List<ClientDTO>> GetClientsAsync(GetClientsRequest request);
        Task<ClientDTO> GetClientAsync(int id);
        Task<ClientDTO> CreateClientAsync(ClientDTO clientDTO);
        Task<ClientDTO> UpdateClientAsync(int id, ClientDTO clientDTO);
        Task<ClientDTO> DeleteClientAsync(int id);
    }
}
