using System;
using System.Collections.Generic;
using Movie.Infrastructure.Repository;
using Movie.Application.Infrastructure;
using Movie.Application.Infrastructure.Queries;
using System.Linq;

namespace Movie.Application.Queries.MovieDetails
{
    public class MovieDetailsQuery : Query<MovieDetailsQueryResult>
    {
        protected IRepository<Domain.Movies.ReadModel.MovieDetailReadModel> _repository = new Repository<Domain.Movies.ReadModel.MovieDetailReadModel>();

        public int Id { get; set; }

        public override QueryExecutionResult<MovieDetailsQueryResult> Execute()
        {
            try
            {
                var result = new MovieDetailsQueryResult();
                var listings = _repository.GetAll().ToList();

                result.Listing = listings.Where(listing=>listing.Id == Id).Select(movie => new MovieDetailsQueryResult
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Salary = movie.Salary,
                    Genres = movie.Genres,
                    Budget = movie.Budget,
                    ImagePath = movie.ImagePath,
                    ReleaseDate = movie.ReleaseDate,
                    Description = movie.Description,
                    MovieDirector = new MovieDetailsDirectorResult()
                    {
                        FullName = movie.MovieDirector.FullName,
                        ImagePath = movie.MovieDirector.ImagePath
                    },
                    MovieActor = movie.MovieActor.Select(mact => new MovieDetailsActorResult
                    {
                        FullName = mact.FullName,
                        ImagePath = mact.ImagePath
                    }).ToList()
                }).ToList();

                return Ok(result);
            }
            catch(Exception exception)
            {
                return Fail(exception);
            }
        }
    }

    public class MovieDetailsQueryResult
    {
        public List<MovieDetailsQueryResult> Listing = new List<MovieDetailsQueryResult>();
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal Budget { get; set; }

        public decimal Salary { get; set; }

        public string ImagePath { get; set; }

        public string Description { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Genres { get; set; }

        public IList<MovieDetailsActorResult> MovieActor { get; set; }

        public MovieDetailsDirectorResult MovieDirector { get; set; }
    }

    public class MovieDetailsActorResult
    {
        public string ImagePath { get; set; }
        public string FullName { get; set; }
    }

    public class MovieDetailsDirectorResult
    {
        public string ImagePath { get; set; }
        public string FullName { get; set; }
    }
}
