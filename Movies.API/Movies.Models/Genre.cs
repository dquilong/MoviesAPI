namespace Movies.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }


    internal enum Genres
    {
        Romance,
        Terror,
        Comedy,
        Drama,
        Thriller,
        Action,
        Mistery,
        Fantasy
    }

}
