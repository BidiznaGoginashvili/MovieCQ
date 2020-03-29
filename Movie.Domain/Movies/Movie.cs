using System;
using Movie.Domain.Actors;
using Movie.Domain.Genres;
using Movie.Domain.Directors;
using System.Collections.Generic;

namespace Movie.Domain.Movies
{
    public class Movie
    {
        public Movie(int id, string title, DateTime releaseDate, decimal budget, decimal salary,
            string description, IList<Genre> genres, IList<MovieActors> movieActors, IList<MovieDirector> movieDirector)
        {
            Id = id;
            Title = title;
            ReleaseDate = releaseDate;
            Budget = budget;
            Salary = salary;
            Description = description;
            Genres = genres;
            MovieActor = movieActors;
            MovieDirector = movieDirector;
        }

        public int Id { get; private set; }

        public string Title { get; private set; }

        public DateTime ReleaseDate { get; set; }

        public decimal Budget { get; private set; }

        public decimal Salary { get; private set; }

        public string Description { get; private set; }

        public IList<Genre> Genres { get; private set; }

        public IList<MovieActors> MovieActor { get; private set; }

        public IList<MovieDirector> MovieDirector { get; private set; }
    }
}
