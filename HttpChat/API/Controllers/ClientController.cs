using HttpChat.API.DTOs;
using HttpChat.Domain;
using HttpChat.Services;
using HttpChat.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HttpChat.API.Controllers
{
    [Route("api/client")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService) { 
            _clientService = clientService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<ClientDTO>> RegisterAsync(string clientName)
        {
            var result = await _clientService.registerClient(clientName);
            return Ok();
        }

    }
}
