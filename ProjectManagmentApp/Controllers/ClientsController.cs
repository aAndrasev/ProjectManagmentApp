using Microsoft.AspNetCore.Mvc;
using ProjectManagmentApp.Application.Dtos;
using ProjectManagmentApp.Application.Dtos.Requests;
using ProjectManagmentApp.Application.Interfaces;

namespace ProjectManagmentApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly ILogger<ClientsController> _logger;
        private readonly IClientService _clientService;

        public ClientsController(ILogger<ClientsController> logger, IClientService clientService)
        {
            _logger = logger;
            _clientService = clientService;
        }



        //******* CRUD METHODS *********//

        [HttpPost("GetAll")]
        public async Task<IActionResult> GetClients(GetClientsRequest request)
        {
            var result = await _clientService.GetClientsAsync(request);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClient(int id)
        {
            var result = await _clientService.GetClientAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateClient(ClientDTO clientDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdClientDto = await _clientService.CreateClientAsync(clientDTO);

            return Ok(createdClientDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClient(int id, ClientDTO clientDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedClientDto = await _clientService.UpdateClientAsync(id, clientDTO);

            if (updatedClientDto == null)
            {
                return NotFound();
            }

            return Ok(updatedClientDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            var deletedClient = await _clientService.DeleteClientAsync(id);
            if (deletedClient == null)
            {
                return NotFound();
            }

            return NoContent();
        }
        //****************//


    }
}
