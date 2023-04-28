using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Training.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok("Hello");
        }
    }
}
