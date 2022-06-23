using Microsoft.EntityFrameworkCore;
using Movies.Models;

namespace Movies.Data
{
    public class MoviesRepository : IMoviesRepository
    {
        private readonly MoviesContext _moviesContext;

        public MoviesRepository(MoviesContext moviesContext)
        {
            _moviesContext = moviesContext;
        }

        public async Task<Movie> GetMovieAsync(int id)
        {
           return await _moviesContext.Movies.Where(x => x.Id == id).FirstAsync();
        }

        public async Task<List<Movie>> GetMoviesAsync()
        {
            return await _moviesContext.Movies.ToListAsync();
        }

        public async Task<Movie> AddMovieAsync(Movie movie)
        {
            await _moviesContext.AddAsync(movie);
            await _moviesContext.SaveChangesAsync();

            return movie;
        }
    }
}
