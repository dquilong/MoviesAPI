using Microsoft.AspNetCore.Mvc;
using Movies.Models;

namespace Movies.API.Controllers
{
    [ApiController]
    public class MoviesController : ControllerBase
    {
        [HttpGet]
        [Route("movie/{id}")]
        public IActionResult Get(int id)
        {
            var movie = new Movie()
            {
                Title = "Black Swan",
                Year = 2010
            };

            return Ok(movie);
        }
    }
}