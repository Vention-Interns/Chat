using HttpChat.API.DTOs;
using HttpChat.Services;
using HttpChat.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HttpChat.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;
        public MessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpPut("message")]
        public ActionResult<ChatDTO> SendMessage(ClientMessageDTO messageDTO)
        {
            // service
            return Ok();
        }
    }
}
