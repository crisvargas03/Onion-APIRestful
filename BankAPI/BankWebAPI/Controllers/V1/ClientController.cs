using Application.Features.Clients.Commands.CreateClientCommad;
using Microsoft.AspNetCore.Mvc;

namespace TrekkoBankAPI.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class ClientController : BaseApiController
    {
        // POST api/controller
        public async Task<IActionResult> Post(CreateClientCommand clientCommand)
        {
            return Ok(await Mediator.Send(clientCommand));
        }
    }
}
