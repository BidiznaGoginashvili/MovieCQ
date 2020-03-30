using System.Collections.Generic;

namespace Movie.Domain.Genres
{
    public class Genre
    {
        public Genre(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }

        public ICollection<MovieGenre> MovieGenres { get; set; }
    }
}
