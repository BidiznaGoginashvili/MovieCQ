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
            string description)
        {
            Id = id;
            Title = title;
            ReleaseDate = releaseDate;
            Budget = budget;
            Salary = salary;
            Description = description;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Budget { get; private set; }
        public decimal Salary { get; private set; }
        public string Description { get; private set; }

        public ICollection<MovieGenre> MovieGenres { get; set; }
        public ICollection<MovieActor> MovieActors { get;  set; }
        public ICollection<MovieDirector> MovieDirectors { get;  set; }
    }
}
