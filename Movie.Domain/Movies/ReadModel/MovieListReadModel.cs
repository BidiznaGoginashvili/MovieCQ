using System;

namespace Movie.Domain.Movies.ReadModel
{
    public class MovieListReadModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ImagePath { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }
    }

    public class MovieListActorReadModel
    {
        public string ImagePath { get; set; }
        public string FullName { get; set; }
    }

    public class MovieListDirectorReadModel
    {
        public string ImagePath { get; set; }
        public string FullName { get; set; }
    }
}
