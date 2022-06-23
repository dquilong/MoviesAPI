using Microsoft.AspNetCore.Mvc;
using Movies.Data;
using Movies.Models;

namespace Movies.API.Controllers
{
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesRepository _moviesRepository;

        public MoviesController(IMoviesRepository moviesRepository)
        {
            _moviesRepository = moviesRepository;
        }

        [HttpGet]
        [Route("movie/{id}")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            var movie = await _moviesRepository.GetMovieAsync(id);

            return Ok(movie);
        }

        [HttpGet]
        [Route("movies")]
        public async Task<ActionResult<Movie>> GetMovies()
        {
            var movies = await _moviesRepository.GetMoviesAsync();

            return Ok(movies);
        }

        [HttpPost]
        [Route("movie")]
        public async Task<ActionResult> AddMovie(Movie movie)
        {
            await _moviesRepository.AddMovieAsync(movie);

            return Ok(movie);
        }

        [HttpPatch]
        [Route("movie")]
        public async Task<ActionResult> UpdateMovie(Movie movie)
        {
            await _moviesRepository.AddMovieAsync(movie);

            return Ok(movie);
        }

    }
}