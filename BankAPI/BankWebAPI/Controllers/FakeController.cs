using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrekkoBankAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}