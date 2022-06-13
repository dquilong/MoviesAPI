using Microsoft.AspNetCore.Mvc;

namespace Movies.API.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("home")]
        public IActionResult Get()
        {
            return Ok("Wellcome to the Movies App");
        }
    }
}