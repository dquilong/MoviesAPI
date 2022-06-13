using System.Text.Json.Serialization;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
        //public List<Genre> Genres { get; set; }

        public int Year { get; set; }
    }
}