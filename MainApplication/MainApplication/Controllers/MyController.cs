using Microsoft.AspNetCore.Mvc;
using MainApplication.Models;

namespace MainApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        [HttpGet("greeting")]
        public ActionResult<string> GetGreeting()
        {
            return Ok("Hello, World!");
        }

        [HttpPost("greet")]
        public ActionResult<string> Greet([FromBody] MyModel model)
        {
            if (model == null || string.IsNullOrEmpty(model.Name))
            {
                return BadRequest("Name is required.");
            }
            return Ok($"Hello, {model.Name}!");
        }
    }
}

