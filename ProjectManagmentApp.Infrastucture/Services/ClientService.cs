using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Interfaces;
using ProjectManagmentApp.Application.Interfaces.Repositories;
using ProjectManagmentApp.Domain.Entities;

namespace ProjectManagmentApp.Infrastucture.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        //***** CRUD METHODS *****//
        public async Task<List<ClientDTO>> GetClientsAsync()
        {
            return await _clientRepository
                 .GetAllAsync()
                 .ProjectTo<ClientDTO>(_mapper.ConfigurationProvider)
                 .ToListAsync();
        }

        public async Task<ClientDTO> GetClientAsync(int id)
        {
            var client = await _clientRepository.GetByIdAsync(id);
            if (client == null)
            {
                return null;
            }

            return _mapper.Map<ClientDTO>(client);
        }

        public async Task<ClientDTO> CreateClientAsync(ClientDTO clientDTO)
        {
            var client = _mapper.Map<Client>(clientDTO);
            var createdClient = await _clientRepository.CreateAsync(client);
            return _mapper.Map<ClientDTO>(createdClient);
        }

        public async Task<ClientDTO> UpdateClientAsync(int id, ClientDTO clientDTO)
        {
            var existingClient = await _clientRepository.GetByIdAsync(id);
            if (existingClient == null)
            {
                return null;
            }

            _mapper.Map(clientDTO, existingClient);
            var updatedClient = await _clientRepository.UpdateAsync(existingClient);

            return _mapper.Map<ClientDTO>(updatedClient);
        }

        public async Task<ClientDTO> DeleteClientAsync(int id)
        {
            var deletedClient = await _clientRepository.DeleteAsync(id);
            if (deletedClient == null)
            {
                return null;
            }

            return _mapper.Map<ClientDTO>(deletedClient);
        }
        //**********//


    }
}
