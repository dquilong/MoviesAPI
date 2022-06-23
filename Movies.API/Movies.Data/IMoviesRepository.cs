using Movies.Models;

namespace Movies.Data
{
    public interface IMoviesRepository
    {
        Task<Movie> GetMovieAsync(int id);

        Task<List<Movie>> GetMoviesAsync();

        Task<Movie> AddMovieAsync(Movie movie);
    }
}