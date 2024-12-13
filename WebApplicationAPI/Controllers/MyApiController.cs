using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "Hello, World!" });
        }
    }
}
