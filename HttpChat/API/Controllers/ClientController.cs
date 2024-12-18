using HttpChat.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HttpChat.API.Controllers
{
    [Route("api/client")]
    [ApiController]
    public class ClientController : ControllerBase
    {

        [HttpPost(Name = "register")]
        public ActionResult<Message> Register()
        {
            return Ok();
        }
    }
}
