using System;
using System.Collections.Generic;

namespace Movie.Domain.Movies.ReadModel
{
    public class MovieDetailReadModel
    {
        public int Id { get;  set; }

        public string Title { get;  set; }

        public decimal Budget { get;  set; }

        public decimal Salary { get;  set; }

        public string ImagePath { get; set; }

        public string Description { get;  set; }

        public DateTime ReleaseDate { get; set; }

        public IList<string> Genres { get;  set; }

        public IList<MovieDetailsActorReadModel> MovieActor { get;  set; }

        public MovieDetailsDirectorReadModel MovieDirector { get;  set; }
    }

    public class MovieDetailsActorReadModel
    {
        public string ImagePath { get; set; }
        public string FullName { get; set; }
    }

    public class MovieDetailsDirectorReadModel 
    {
        public string ImagePath { get; set; }
        public string FullName { get; set; }
    }
}
