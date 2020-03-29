using System.Collections.Generic;

namespace Movie.Domain.Genres
{
    public class Genre
    {
        public Genre(int id, string title, IList<Movies.Movie> movies)
        {
            Id = id;
            Title = title;
            Movies = movies;
        }

        public int Id { get; private set; }

        public string Title { get; private set; }

        public virtual IList<Movies.Movie> Movies { get; private set; }
    }
}
