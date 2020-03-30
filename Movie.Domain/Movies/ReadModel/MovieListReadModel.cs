using System;
using System.Collections.Generic;

namespace Movie.Domain.Movies.ReadModel
{
    public class MovieListReadModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }

        public string Genres { get; set; }

        public ICollection<MovieListActorReadModel> MovieActor { get; set; }

        public MovieListDirectorReadModel MovieDirector { get; set; }
    }

    public class MovieListActorReadModel
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string FullName { get; set; }

        public MovieListReadModel MovieListReadModel { get; set; }
    }

    public class MovieListDirectorReadModel
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string FullName { get; set; }

        public int MovieListReadModelId { get; set; }
        public MovieListReadModel MovieListReadModel { get; set; }
    }
}
